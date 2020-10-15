using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Modelo
{
    public class CategoriaModelo
    {
        //creacion de la tabla categoria

        public DataTable tablac = new DataTable();
        private bool columnas = false;

        // columnas de la tabla
        DataColumn idt = new DataColumn("ID", typeof(string));
        DataColumn namet = new DataColumn("Name", typeof(string));
        DataColumn estadot = new DataColumn("Estado", typeof(string));

        //Listar Los productos
        public DataTable ListProduct(string idC, string nameC, string estadoC)
        {
            if (columnas == false)
            {
                tablac.Columns.Add(idt);
                tablac.Columns.Add(namet);
                tablac.Columns.Add(estadot);
               

                columnas = true;
            }


            /* public CategoriaModelo(int idCategoria, int nombre, int estado)
             {
                 IdCategoria = idCategoria;
                 Nombre = nombre;
                 Estado = estado;
             }

             public int IdCategoria { get; set; }
             public int Nombre { get; set; }
             public int Estado { get; set; }*/

            DataRow fila = tablac.NewRow();
            fila[0] = idC;
            fila[1] = nameC;
            fila[2] = estadoC;
            

            tablac.Rows.Add(fila);


            return tablac;


        }
    }
}