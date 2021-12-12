using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entity
{
    public class PedidoEntity : DBEntity
    {
        public PedidoEntity()
        {
           
            Producto = Producto ?? new ProductoEntity();
            Cliente = Cliente ?? new ClienteEntity();
        }
        public int? IdPedido { get; set; }
        public int? Envio { get; set; }

        public int? SubTotal { get; set; }
        public int? Impuesto { get; set; }
        public int? Total { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.Now;
        public int? IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public Decimal Precio { get; set; }       
        
        public virtual ProductoEntity Producto { get; set; }
        public int? IdProducto { get; set; }

        public virtual ClienteEntity Cliente { get; set; }
        public int? IdCliente { get; set; }


    }
}
