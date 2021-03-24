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

            foreach (int ID in OrderStock.partsIDs)
            {
                Label partIDLbl = new Label();
                Label currentStockLbl = new Label();
                Label necessaryStockLbl = new Label();
                NumericUpDown orderStockUpDown = new NumericUpDown();

                partIDLbl.Text = ID.ToString();
                partIDLbl.Top = position * 20;
                partIDLbl.Left = 20;
                partIDLbl.Size = new Size(30, 16);
                partIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                //partNameLbl.Text = OrderStock.partsNames;
                //partNameLbl.Top = position * 20 + 20;
                //partNameLbl.Left = 4;
                //partNameLbl.Size = new Size(30, 20);

                currentStockLbl.Text = OrderStock.GetPartStock(ID).ToString();
                currentStockLbl.Top = position * 20;
                currentStockLbl.Left = 225;
                currentStockLbl.Size = new Size(30, 16);
                currentStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                necessaryStockLbl.Text = "idk";
                necessaryStockLbl.Top = position * 20;
                necessaryStockLbl.Left = 410;
                necessaryStockLbl.Size = new Size(30, 16);
                necessaryStockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                orderStockUpDown.Top = position * 20;
                orderStockUpDown.Left = 615;
                orderStockUpDown.Size = new Size(61, 20);

                position = position + 2;

                part_stock_panel.Controls.Add(partIDLbl);
                part_stock_panel.Controls.Add(currentStockLbl);
                part_stock_panel.Controls.Add(necessaryStockLbl);
                part_stock_panel.Controls.Add(orderStockUpDown);
            }

            position = 1;

            foreach (string name in OrderStock.partsNames)
            {
                Label partNameLbl = new Label();

                partNameLbl.Text = name;
                partNameLbl.Top = position * 20;
                partNameLbl.Left = 63;
                partNameLbl.Size = new Size(120, 20);
                partNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                position = position + 2;

                part_stock_panel.Controls.Add(partNameLbl);
            }
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
