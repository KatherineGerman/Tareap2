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
			if (txtid.Text == "ID" || txtcode.Text == "code" || txtname.Text == "Product Name" || txtstock.Text == "stock" || txtcategory.Text == "Category" || txtexpired.Text == "expired" || cmbState.Text == "State" || txtdescription.Text == "Description")
			{
				MessageBox.Show("Fill empty fields");
			}
			else
			{
				string id, code, name, stock, category, expired, state, description;
				id = txtid.Text;
				code = txtcode.Text;
				name = txtname.Text;
				stock = txtstock.Text;
				category = txtcategory.Text;
				expired = txtexpired.Text;
				state = cmbState.Text;
				description = txtdescription.Text;

				gvproducts.DataSource = productoP.Mostrar(id, code, name, stock, expired, category, state, description);
			}
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
				cmbState.Text = gvproducts.CurrentRow.Cells[6].Value.ToString();
				txtdescription.Text = gvproducts.CurrentRow.Cells[7].Value.ToString();
				gvproducts.Rows.RemoveAt(this.gvproducts.SelectedRows[0].Index);

			}
            else
                MessageBox.Show("Please, select a row to edit");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
			if (this.gvproducts.SelectedRows.Count > 0)
            {
				gvproducts.Rows.RemoveAt(this.gvproducts.SelectedRows[0].Index);
            }
			else
				MessageBox.Show("Please, select a row to delete");
		}

        private void txtid_Enter(object sender, EventArgs e)
        {
			if(txtid.Text == "ID")
            {
				txtid.Text = "";
				txtid.ForeColor = Color.Black;
            }
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
			if (txtid.Text == "")
			{
				txtid.Text = "ID";
				txtid.ForeColor = Color.Silver;
			}
		}

        private void txtcode_Enter(object sender, EventArgs e)
        {
			if(txtcode.Text == "code")
            {
				txtcode.Text = "";
				txtcode.ForeColor = Color.Black;
            }
        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
			if (txtcode.Text == "")
			{
				txtcode.Text = "code";
				txtcode.ForeColor = Color.Silver;
			}
		}

        private void txtname_Enter(object sender, EventArgs e)
        {
			if(txtname.Text == "Product Name")
            {
				txtname.Text = "";
				txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
			if (txtname.Text == "")
			{
				txtname.Text = "Product Name";
				txtname.ForeColor = Color.Silver;
			}
		}

        private void txtstock_Enter(object sender, EventArgs e)
        {
			if(txtstock.Text == "stock")
            {
				txtstock.Text = "";
				txtstock.ForeColor = Color.Black;
            }
        }

        private void txtstock_Leave(object sender, EventArgs e)
        {
			if (txtstock.Text == "")
			{
				txtstock.Text = "stock";
				txtstock.ForeColor = Color.Silver;
			}
		}

        private void txtexpired_Enter(object sender, EventArgs e)
        {
			if(txtexpired.Text == "expired")
            {
				txtexpired.Text = "";
				txtexpired.ForeColor = Color.Black;
            }
        }

        private void txtexpired_Leave(object sender, EventArgs e)
        {
			if (txtexpired.Text == "")
			{
				txtexpired.Text = "expired";
				txtexpired.ForeColor = Color.Silver;
			}
		}

        private void txtcategory_Enter(object sender, EventArgs e)
        {
			if(txtcategory.Text == "Category")
            {
				txtcategory.Text = "";
				txtcategory.ForeColor = Color.Black;
            }
		}

        private void txtcategory_Leave(object sender, EventArgs e)
        {
			if (txtcategory.Text == "")
			{
				txtcategory.Text = "Category";
				txtcategory.ForeColor = Color.Silver;
			}
		}

        private void cmbState_Enter(object sender, EventArgs e)
        {
			if(cmbState.Text == "State")
            {
				cmbState.Text = "";
				cmbState.ForeColor = Color.Black;
            }
        }

        private void cmbState_Leave(object sender, EventArgs e)
        {
			if (cmbState.Text == "")
			{
				cmbState.Text = "State";
				cmbState.ForeColor = Color.Silver;
			}
		}

        private void txtdescription_Enter(object sender, EventArgs e)
        {
			if (txtdescription.Text == "Description")
            {
				txtdescription.Text = "";
				txtdescription.ForeColor = Color.Black;
            }
        }

        private void txtdescription_Leave(object sender, EventArgs e)
        {
			if (txtdescription.Text == "")
			{
				txtdescription.Text = "Description";
				txtdescription.ForeColor = Color.Silver;
			}
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
