using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMarket.Vista;
using System.Runtime.InteropServices;

using EMarket.Controlador;
using Negocio;

namespace EMarket
{
    public partial class Form1 : Form
    {

        private ProductoControlador productoP = new ProductoControlador();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {

        }

        private void btnListP_Click(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

        

        private void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la conexion el formulario
            //Si el formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }//si  el formulario ya existe
            else
            {
                formulario.BringToFront();
            }
        }

		private void btncategories_Paint(object sender, PaintEventArgs e)
		{
            

        }

		private void button1_Click(object sender, EventArgs e)
		{
            AbrirForm<CategoriaVista>();
        }

		private void button2_Click(object sender, EventArgs e)
		{
            AbrirForm<ProductoVista>();
		}

		private void panelFormulario_Paint(object sender, PaintEventArgs e)
		{

		}

        private void ViewProducts()
        {

        }

        private void update_Tick(object sender, EventArgs e)
        {
            if (SharedVar.id != "")
            {
                gvmain.DataSource = productoP.Mostrar(SharedVar.id, SharedVar.code, SharedVar.name, SharedVar.stock, SharedVar.expired, SharedVar.category, SharedVar.state, SharedVar.description);

                SharedVar.id = "";
            }
            
            

        }
    }
}
