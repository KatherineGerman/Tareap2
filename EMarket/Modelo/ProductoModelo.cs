using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EMarket.Modelo
{
   public class ProductoModelo
    {
        //Creacion de la tabla de productos
       public  DataTable tabla = new DataTable();
        private bool columnas = false;

        //creamos las  columnas de la tabla
        DataColumn idt = new DataColumn("ID", typeof(string));
        DataColumn codet = new DataColumn("Code", typeof(string));
        DataColumn namet = new DataColumn("Name", typeof(string));
        DataColumn stockt = new DataColumn("Stock", typeof(string));
        DataColumn expiredt = new DataColumn("Expired Date", typeof(string));
        DataColumn categoryt = new DataColumn("Category", typeof(string));
        DataColumn statet = new DataColumn("State", typeof(string));
        DataColumn descriptiont = new DataColumn("Description", typeof(string));


/*
        public ProductoModeloo(int idProducto, string nombreP, string codigoP, string stockP, DateTime fVencimiento, string descripcionP, string categoriaP, string estado)
        {
            IdProducto = idProducto;
            NombreP = nombreP;
            CodigoP = codigoP;
            StockP = stockP;
            FVencimiento = fVencimiento;
            DescripcionP = descripcionP;
            CategoriaP = categoriaP;
            Estado = estado;
        }

        public int IdProducto { get; set; }
        public string NombreP { get; set; }
        public string CodigoP { get; set; }
        public string StockP { get; set; }
        public DateTime FVencimiento { get; set; }
        public string DescripcionP { get; set; }
        public string CategoriaP { get; set; }
        public string Estado { get; set; }*/


        //Listar Los productos
        public DataTable ListProduct(string id, string code, string name, string stock, string expired, string category, string state, string description)
        {
            if (columnas==false)
            {
                tabla.Columns.Add(id);
                tabla.Columns.Add(code);
                tabla.Columns.Add(name);
                tabla.Columns.Add(stock);
                tabla.Columns.Add(expired);
                tabla.Columns.Add(category);
                tabla.Columns.Add(state);
                tabla.Columns.Add(description);

                columnas = true;
            }

            

            /* tabla.Rows.Add(id, code, name, stock, expired, category, state, description);

           DataRow idT = tabla.NewRow();
           idT[0] = code;
           DataRow codeT = tabla.NewRow();
           codeT[0] = code;
           DataRow nameT = tabla.NewRow();
           nameT[0] = name;
           /  DataRow idT = tabla.NewRow();
             idT[0] = id;
             DataRow idT = tabla.NewRow();
             idT[0] = id;
             DataRow idT = tabla.NewRow();
             idT[0] = id;
             DataRow idT = tabla.NewRow();
             idT[0] = id;
             DataRow idT = tabla.NewRow();
             idT[0] = id;*/
            DataRow fila = tabla.NewRow();
            fila[0] = id;
            fila[1] = code;
            fila[2] = name;
            fila[3] = stock;
            fila[4] = expired;
            fila[5] = category;
            fila[6] = state;
            fila[7] = description;

          

            tabla.Rows.Add(fila);


            return tabla;
        }
    }

 
}
