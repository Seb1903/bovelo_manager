using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bovelo
{
    public partial class StockManagerForm : Form
    {
        public StockManagerForm()
        {
            InitializeComponent();
        }

        private void StockManagerForm_Load(object sender, EventArgs e)
        {
            OrderStock.GetPartCatalog();

            int position = 1;
            int i = 0;

            foreach (KeyValuePair<string, int> parts in OrderStock.partsNecessaryStock)
            {
                OrderStock.ChangeQuantity(parts.Key, parts.Value);

                Label partIDLbl = new Label();
                Label necessaryStockLbl = new Label();
                idNumericUpDown orderStockUpDown = new idNumericUpDown(parts.Key);
                Label supplierNameLbl = new Label();
                Label partNameLbl = new Label();
                Label currentStockLbl = new Label();

                partIDLbl.Text = parts.Key;
                partIDLbl.Top = position * 20;
                partIDLbl.Left = 10;
                partIDLbl.Size = new Size(40, 16);
                partIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                necessaryStockLbl.Text = parts.Value.ToString();
                necessaryStockLbl.Top = position * 20;
                necessaryStockLbl.Left = 410;
                necessaryStockLbl.Size = new Size(30, 16);
                necessaryStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                orderStockUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
                if (OrderStock.partsQuantityOrder[parts.Key] >= OrderStock.partsStock[i])
                {
                    orderStockUpDown.Value = OrderStock.partsQuantityOrder[parts.Key] - OrderStock.partsStock[i] + 10; //minimal stock : 10 parts
                    orderStockUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                }
                else
                {
                    orderStockUpDown.Value = 0;
                }
                orderStockUpDown.Top = position * 20;
                orderStockUpDown.Left = 572;
                orderStockUpDown.Size = new Size(61, 20);
                orderStockUpDown.ValueChanged += OrderStockUpDown_ValueChanged;

                supplierNameLbl.Text = OrderStock.partsSuppliersNames[i];
                supplierNameLbl.Top = position * 20;
                supplierNameLbl.Left = 700;
                supplierNameLbl.Size = new Size(120, 20);
                supplierNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                partNameLbl.Text = OrderStock.partsNames[i];
                partNameLbl.Top = position * 20;
                partNameLbl.Left = 63;
                partNameLbl.Size = new Size(120, 20);
                partNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                currentStockLbl.Text = OrderStock.partsStock[i].ToString();
                currentStockLbl.Top = position * 20;
                currentStockLbl.Left = 225;
                currentStockLbl.Size = new Size(30, 16);
                currentStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                position = position + 2;
                i++;

                part_stock_panel.Controls.Add(partIDLbl);
                part_stock_panel.Controls.Add(necessaryStockLbl);
                part_stock_panel.Controls.Add(orderStockUpDown);
                part_stock_panel.Controls.Add(supplierNameLbl);
                part_stock_panel.Controls.Add(partNameLbl);
                part_stock_panel.Controls.Add(currentStockLbl);
            }
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, int> parts in OrderStock.partsQuantityOrder)
            {
                //Console.WriteLine("Clé : {0}, valeur : {1}", parts.Key, parts.Value);
                OrderStock.OrderToSupplier(parts.Key, parts.Value);
                OrderStock.SetNewNecessaryStock(parts.Key, parts.Value);
            }
            orderDone_Lbl.Text = "Order sent to the suppliers";
        }

        private void OrderStockUpDown_ValueChanged(object sender, EventArgs e)
        {
            int new_quantity = Convert.ToInt32((sender as idNumericUpDown).Value.ToString());
            string id = (sender as idNumericUpDown).id;
            OrderStock.ChangeQuantity(id, new_quantity);
        }

        private void Add_Part_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PartsCatalog form = new PartsCatalog();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }
    }

    public class idNumericUpDown : NumericUpDown
    {
        public string id;
        public idNumericUpDown(string id)
        {
            this.id = id;
        }
    }
}
