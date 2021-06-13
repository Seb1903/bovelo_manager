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
            int position = 1;

            foreach (Part part in OrderStock.partList)
            {
                if(part.necessary - part.stock > 0)
                {
                    OrderStock.ChangeQuantity(part.reference, part.necessary - part.stock); // necessary - (stock+ordered) = quantity of parts to order
                }
                else
                {
                    OrderStock.ChangeQuantity(part.reference, 0);
                }

                Label partIDLbl = new Label();
                Label necessaryStockLbl = new Label();
                idNumericUpDown orderStockUpDown = new idNumericUpDown(part.reference);
                Label supplierNameLbl = new Label();
                Label partNameLbl = new Label();
                Label currentStockLbl = new Label();

                partIDLbl.Text = part.reference;
                partIDLbl.Top = position * 20;
                partIDLbl.Left = 10;
                partIDLbl.Size = new Size(40, 16);
                partIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                necessaryStockLbl.Text = part.necessary.ToString();
                necessaryStockLbl.Top = position * 20;
                necessaryStockLbl.Left = 410;
                necessaryStockLbl.Size = new Size(30, 16);
                necessaryStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                orderStockUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
                orderStockUpDown.Value = part.quantity;
                if (orderStockUpDown.Value != 0)
                {
                    orderStockUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                }
                orderStockUpDown.Top = position * 20;
                orderStockUpDown.Left = 572;
                orderStockUpDown.Size = new Size(61, 20);
                orderStockUpDown.ValueChanged += OrderStockUpDown_ValueChanged;

                partNameLbl.Text = part.name;
                partNameLbl.Top = position * 20;
                partNameLbl.Left = 63;
                partNameLbl.Size = new Size(120, 20);
                partNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                currentStockLbl.Text = part.stock.ToString();
                currentStockLbl.Top = position * 20;
                currentStockLbl.Left = 225;
                currentStockLbl.Size = new Size(40, 16);
                currentStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                position = position + 2;

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
            foreach(Part part in OrderStock.partList)
            {
                if(part.quantity>0)
                {
                    OrderStock.OrderToSupplier(part.reference, part.quantity);
                    OrderStock.SetNewNecessaryStock(part.reference, part.quantity, part.stock);
                }
                
            }
            orderDone_Lbl.Text = "Order sent to the suppliers";
        }

        private void OrderStockUpDown_ValueChanged(object sender, EventArgs e)
        {
            int new_quantity = Convert.ToInt32((sender as idNumericUpDown).Value.ToString());
            string id = (sender as idNumericUpDown).id;
            OrderStock.ChangeQuantity(id, new_quantity);
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
