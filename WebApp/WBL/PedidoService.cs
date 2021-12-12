using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IPedidoService
    {
        Task<DBEntity> Create(PedidoEntity entity);
        Task<DBEntity> Delete(PedidoEntity entity);
        Task<IEnumerable<PedidoEntity>> Get();
        Task<PedidoEntity> GetById(PedidoEntity entity);
        Task<DBEntity> Update(PedidoEntity entity);

        Task<IEnumerable<PedidoEntity>> GetLista();
    }

    public class PedidoService : IPedidoService
    {
        private readonly IDataAccess sql;

        public PedidoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<PedidoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidoEntity, ProductoEntity,ClienteEntity>("ObtenerPedido", "IdPedido,IdProducto,IdCliente");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<PedidoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<PedidoEntity>("ObtenerPedido");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<PedidoEntity> GetById(PedidoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidoEntity>("ObtenerPedido", new
                { entity.IdPedido });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarPedido", new
                {

                    entity.Envio,
                    entity.SubTotal,
                    entity.Impuesto,
                    entity.Total,
                    entity.FechaPedido,
                    entity.IdCliente,
                    entity.Cantidad,
                    entity.Precio,
                    entity.IdProducto



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarPedido", new
                {
                    
                    entity.IdPedido,
                    entity.Envio,
                    entity.SubTotal,
                    entity.Impuesto,
                    entity.Total,
                    entity.FechaPedido,
                    entity.IdCliente,
                    entity.Cantidad,
                    entity.Precio,
                    entity.IdProducto


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarPedido", new
                {
                    entity.IdPedido,



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }






        #endregion



    }
}
