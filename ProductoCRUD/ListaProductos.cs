using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoCRUD
{
    class ListaProductos
    {
        public int ProductoId { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal CoefUtil { get; set; }
        public bool Estado { get; set; }
    }
}
