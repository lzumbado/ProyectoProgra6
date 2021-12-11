using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IPedidoEncabezadoService
    {
        Task<DBEntity> Create(PedidoEncabezadoEntity entity);
        Task<DBEntity> Delete(PedidoEncabezadoEntity entity);
        Task<IEnumerable<PedidoEncabezadoEntity>> Get();
        Task<PedidoEncabezadoEntity> GetById(PedidoEncabezadoEntity entity);
        Task<DBEntity> Update(PedidoEncabezadoEntity entity);

        Task<IEnumerable<PedidoEncabezadoEntity>> GetLista();
    }

    public class PedidoEncabezadoService : IPedidoEncabezadoService
    {
        private readonly IDataAccess sql;

        public PedidoEncabezadoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<PedidoEncabezadoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidoEncabezadoEntity, ClienteEntity>("ObtenerPedido", "IdPedido,IdCliente");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<PedidoEncabezadoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<PedidoEncabezadoEntity>("ObtenerPedido");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<PedidoEncabezadoEntity> GetById(PedidoEncabezadoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidoEncabezadoEntity>("ObtenerPedido", new
                { entity.IdPedido });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(PedidoEncabezadoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarPedido", new
                {
                    entity.IdPedido,
                    entity.Envio,
                    entity.SubTotal,
                    entity.Impuesto,
                    entity.Total,
                    entity.FechaPedido,
                    entity.IdCliente



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(PedidoEncabezadoEntity entity)
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
                    entity.IdCliente


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(PedidoEncabezadoEntity entity)
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
