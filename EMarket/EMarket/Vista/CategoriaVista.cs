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
    public partial class CategoriaVista : Form
    {
        private CategoriaControlador categoriaM = new CategoriaControlador();
        public CategoriaVista()
        {
            InitializeComponent();
        }

		

		private void button5_Click_1(object sender, EventArgs e)
		{
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id,  Cname, Cestado;
            id = textidc.Text;
            Cname = txtdescription.Text;
            Cestado = cmbState.Text;
            
            gvproducts.DataSource = categoriaM.Mostrar(id,  Cname, Cestado);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (gvproducts.SelectedRows.Count > 0)
            {

                textidc.Text = gvproducts.CurrentRow.Cells[0].Value.ToString();
                txtdescription.Text = gvproducts.CurrentRow.Cells[1].Value.ToString();
                cmbState.Text = gvproducts.CurrentRow.Cells[2].Value.ToString();
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

        private void textidc_Enter(object sender, EventArgs e)
        {
            if (textidc.Text == "ID")
            {
                textidc.Text = "";
                textidc.ForeColor = Color.Black;
            }
        }

        private void textidc_Leave(object sender, EventArgs e)
        {
            if (textidc.Text == "")
            {
                textidc.Text = "ID";
                textidc.ForeColor = Color.Silver;
            }
        }

        private void txtdescription_Enter(object sender, EventArgs e)
        {
            if (txtdescription.Text == "Category Name")
            {
                txtdescription.Text = "";
                txtdescription.ForeColor = Color.Black;
            }
        }

        private void txtdescription_Leave(object sender, EventArgs e)
        {
            if (txtdescription.Text == "")
            {
                txtdescription.Text = "Category Name";
                txtdescription.ForeColor = Color.Silver;
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
    }
}
