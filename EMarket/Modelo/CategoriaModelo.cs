using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.Modelo
{
    class CategoriaModelo
    {
        public CategoriaModelo(int idCategoria, int nombre, int estado)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Estado = estado;
        }

        public int IdCategoria { get; set; }
        public int Nombre { get; set; }
        public int Estado { get; set; }
    }
}
