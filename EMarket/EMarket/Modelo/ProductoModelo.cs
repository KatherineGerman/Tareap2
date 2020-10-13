using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Modelo
{
    class ProductoModelo
    {
        public ProductoModelo(int idProducto, string nombreP, string codigoP, string stockP, DateTime fVencimiento, string descripcionP, string categoriaP, string estado)
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
        public string Estado { get; set; }
    }
}
