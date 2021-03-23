using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bovelo
{
    public class Bike
    {
        public int id;
        public string type;
        public string color;
        public string size;
        public int price;
        public string state;
        public List<Part> partList = new List<Part>();
        public DateTime cstr_date; 

        public Bike(int id)
        {
            this.id = id;
            DataRow bikeRow = InternalApp.bikeTable.AsEnumerable().Single(r => r.Field<int>("id") == this.id);
            this.type = bikeRow.Field<string>("type");
            this.color = bikeRow.Field<string>("color");
            this.size = bikeRow.Field<string>("size");
            this.state = bikeRow.Field<string>("cstr_status");
            try
            {
                DataRow dateRow = InternalApp.planningTable.AsEnumerable().Single(r => r.Field<int>("bike") == id);
                DateTime date = dateRow.Field<DateTime>("date");
                this.cstr_date = date;
            }
            catch { // check the try/catch
            }     
        }

        public Bike() { } // needed to create models in NewModel form

        public void Build()
        {
            DataTable partTable = InternalApp.GetDataTable($"SELECT * FROM model_structure WHERE model_name='{type}'");
            foreach(DataRow partRow in partTable.Rows)
            {
                Part part = new Part(partRow.Field<string>("reference"), partRow.Field<int>("quantity"));
                this.AddPart(part);
                part.Use(); 
            }
            this.ModifyState("Done"); //Comment for testing
        }

        public void AddPart(Part part) //Useful for NewModels, partList can thus become a private attribute
        {
            partList.Add(part);
        }

        public void DeletePart(string reference)
        {
            var itemToRemove = partList.Single(r => r.reference == reference);
            partList.Remove(itemToRemove);
        }

        public override string ToString()
        {
            Console.WriteLine("\n-------------\nParts List:\n-------------");
            foreach (Part part in partList)
            {
                Console.WriteLine("\nType: {0}\n--Stock = {1}\n--Quantity used = {2}",
                    part.name, part.stock, part.quantity);
            }
            return ("\n" + type + " " + size + " " + color);
        }

        public void ModifyDate(string date)
        {
            InternalApp.ExecuteQuery($"UPDATE planning SET date='{date}' WHERE bike='{this.id}'");
        }

        public void ModifyState(string state)
        {
            this.state = state;
            InternalApp.ExecuteQuery($"UPDATE bike SET cstr_status='{state}' WHERE id='{this.id}'");
        }

        public void SaveModel()      //needs to be cleaned, create methods in database GetData and SendData 
        {
            InternalApp.ExecuteQuery($"INSERT into model_catalog(name, price) values('{type}', '{price}');");
            
            foreach (Part part in partList)
                InternalApp.ExecuteQuery($"INSERT into model_structure(model_name, reference, quantity) values('{type}','{part.reference}', '{part.quantity}');");
        }
    }
}

