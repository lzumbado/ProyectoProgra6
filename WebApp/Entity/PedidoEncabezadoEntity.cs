using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PedidoEncabezadoEntity : DBEntity
    {
        public PedidoEncabezadoEntity()
        {
            Clientes = Clientes ?? new ClientesEntity();
        }

        public int? IdPedido { get; set; }
        public int? Envio{ get; set; }

        public int? SubTotal { get; set; }
        public int? Impuesto { get; set; }
        public int? Total { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Now;

        public virtual ClientesEntity Clientes { get; set; }

        public int? IdCliente { get; set; }


    }
}
