using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IPedidoDetalleService
    {
        Task<DBEntity> Create(PedidoDetalleEntity entity);
        Task<DBEntity> Delete(PedidoDetalleEntity entity);
        Task<IEnumerable<PedidoDetalleEntity>> Get();
        Task<PedidoDetalleEntity> GetById(PedidoDetalleEntity entity);
        Task<DBEntity> Update(PedidoDetalleEntity entity);

        Task<IEnumerable<PedidoDetalleEntity>> GetLista();
    }

    public class PedidoDetalleService : IPedidoDetalleService
    {
        private readonly IDataAccess sql;

        public PedidoDetalleService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<PedidoDetalleEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidoDetalleEntity,PedidoEncabezadoEntity, ProductoEntity>("ObtenerPedido", "IdDetalle,IdPedido,IdProducto");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<PedidoDetalleEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<PedidoDetalleEntity>("ObtenerPedido");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<PedidoDetalleEntity> GetById(PedidoDetalleEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidoDetalleEntity>("ObtenerPedido", new
                { entity.IdDetalle });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(PedidoDetalleEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarPedido", new
                {
                    entity.IdDetalle,
                    entity.Cantidad,
                    entity.Precio,
                    entity.IdPedido,
                    entity.IdProducto,                    

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(PedidoDetalleEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarPedido", new
                {
                    entity.IdDetalle,
                    entity.Cantidad,
                    entity.Precio,
                    entity.IdPedido,
                    entity.IdProducto,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(PedidoDetalleEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarPedido", new
                {
                    entity.IdDetalle,

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
