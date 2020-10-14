using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EMarket.Modelo;

namespace EMarket.Controlador
{
    public class CategoriaControlador
    {
        public CategoriaModelo categoriaM = new CategoriaModelo();
        public DataTable Mostrar(string idCt, string nameCt, string estadoCt)
        {
            return categoriaM.ListProduct(idCt, nameCt, estadoCt);
        }
    }
}
