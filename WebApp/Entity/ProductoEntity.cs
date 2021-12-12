using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoEntity : DBEntity
    {
        public ProductoEntity()
        {
            Categoria = Categoria ?? new CategoriaEntity();
        }
        public int? IdProducto { get; set; }
        public string NombreProducto{ get; set; }
       
        public int? CantidadDisponible { get; set; }
        public string Caracteristicas { get; set; }
        public Boolean Estado { get; set; }

        public virtual CategoriaEntity Categoria { get; set; }

        public int? IdCategoria { get; set; }

    }
}
