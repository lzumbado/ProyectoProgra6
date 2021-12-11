using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PedidoDetalleEntity : DBEntity
    {
        public PedidoDetalleEntity()
        {
            PedidoEncabezado = PedidoEncabezado ?? new PedidoEncabezadoEntity();

            Productos = Productos ?? new ProductosEntity();
        }
        public int? IdDetalle { get; set; }
        public int? Cantidad { get; set; }
        public virtual PedidoEncabezadoEntity PedidoEncabezado { get; set; }
        public int? IdPedido { get; set; }
        public virtual ProductosEntity Productos { get; set; }
        public int? IdProducto { get; set; }



    }
}
