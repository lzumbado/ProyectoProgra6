using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class ProductosEntity
    {
        public ProductosEntity()
        {
            Categorias = Categorias ?? new CategoriasEntity();
        }
        public int? IdProducto { get; set; }
        public string NombreProducto{ get; set; }
        public Decimal Identificacion { get; set; }

        public int? CantidadDisponible { get; set; }
        public string Caracteristicas { get; set; }
        public Boolean Estado { get; set; }

        public virtual CategoriasEntity Categorias { get; set; }

        public int? IdCategoria { get; set; }

    }
}
