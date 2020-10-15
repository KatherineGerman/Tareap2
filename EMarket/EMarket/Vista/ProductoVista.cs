using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMarket.Controlador;

namespace EMarket.Vista
{
    public partial class ProductoVista : Form
    {

		private ProductoControlador productoP = new ProductoControlador();
        public ProductoVista()
        {
            InitializeComponent();
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			string id, code, name, stock, category, expired, state, description;
			id = txtid.Text;
			code = txtcode.Text;
			name = txtname.Text;
			stock = txtstock.Text;
			category = txtcategory.Text;
			expired = txtexpired.Text;
			state = cbstate.Text;
			description = txtdescription.Text;

			gvproducts.DataSource = productoP.Mostrar(id,code,name,stock,expired,category,state,description);
		}

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (gvproducts.SelectedRows.Count > 0)
            {
               
                txtid.Text = gvproducts.CurrentRow.Cells[0].Value.ToString();
				txtcode.Text = gvproducts.CurrentRow.Cells[1].Value.ToString();
				txtname.Text = gvproducts.CurrentRow.Cells[2].Value.ToString();
				txtstock.Text = gvproducts.CurrentRow.Cells[3].Value.ToString();
				txtexpired.Text = gvproducts.CurrentRow.Cells[4].Value.ToString();
				txtcategory.Text = gvproducts.CurrentRow.Cells[5].Value.ToString();
				cbstate.Text = gvproducts.CurrentRow.Cells[6].Value.ToString();
				txtdescription.Text = gvproducts.CurrentRow.Cells[7].Value.ToString();
				gvproducts.Rows.RemoveAt(this.gvproducts.SelectedRows[0].Index);

			}
            else
                MessageBox.Show("Plase, select a row to edit");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
			if (this.gvproducts.SelectedRows.Count > 0)
            {
				gvproducts.Rows.RemoveAt(this.gvproducts.SelectedRows[0].Index);
            }
			else
				MessageBox.Show("Plase, select a row to delete");
		}

        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
			foreach (DataGridViewRow Row in gvproducts.Rows)
			{
				String strFila = Row.Index.ToString();
				string valor = Convert.ToString(Row.Cells["code"].Value);

				if (valor == this.txtsearch.Text)
				{
					gvproducts.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Green;
				}
			}
		}
    }
}
