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
    public partial class PartsCatalog : Form
    {
        string partInfo = "";
        string partParams = "";
        public PartsCatalog()
        {
            InitializeComponent();
            DataTable parts = InternalApp.GetDataTable("Select * from parts_catalog");
            partsCatalogGridView.DataSource = parts;
        }

        private void partsCatalogGridView_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            partInfo = "";
            int column = 0;
            try
            {
                while (column < partsCatalogGridView.ColumnCount)
                {
                    partInfo += (partsCatalogGridView.Rows[e.RowIndex].Cells[column].Value.ToString());
                    partInfo += " ";
                    column++;
                }
                partParams = partsCatalogGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                partSelected_Lbl.Text = partInfo;
            }
            catch
            {
                partSelected_Lbl.Text = "";
            }
        }

        private void addPart_Btn_Click(object sender, EventArgs e)
        {
            OrderStock.GetNewPart(partParams);

            this.Hide();
            StockManagerForm form = new StockManagerForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockManagerForm form = new StockManagerForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }
    }
}
