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
 public    class ProductoControlador
    {
        public ProductoModelo productoM = new ProductoModelo();
        public DataTable Mostrar(string idP, string codeP, string nameP, string stockP, string expiredP, string categoryP, string stateP, string descriptionP)
        {
           return productoM.ListProduct(idP, codeP, nameP, stockP, expiredP, categoryP, stateP, descriptionP); 
        }
    }
}
