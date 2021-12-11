using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClientesService
    {
        Task<DBEntity> Create(ClientesEntity entity);
        Task<DBEntity> Delete(ClientesEntity entity);
        Task<IEnumerable<ClientesEntity>> Get();
        Task<ClientesEntity> GetById(ClientesEntity entity);
        Task<DBEntity> Update(ClientesEntity entity);

        Task<IEnumerable<ClientesEntity>> GetLista();
    }

    public class ClientesService : IClientesService
    {
        private readonly IDataAccess sql;

        public ClientesService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<ClientesEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ClientesEntity>("ObtenerCliente");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ClientesEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<ClientesEntity>("ObtenerCliente");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<ClientesEntity> GetById(ClientesEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ClientesEntity>("ObtenerCliente", new
                { entity.IdCliente });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarCliente", new
                {
                    entity.IdCliente,
                    entity.Cedula,
                    entity.Nombre,
                    entity.Apellido1,
                    entity.Apellido2,
                    entity.Direccion,
                    entity.Telefono,
                    entity.FechaNacimiento,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarCliente", new
                {
                    entity.IdCliente,
                    entity.Cedula,
                    entity.Nombre,
                    entity.Apellido1,
                    entity.Apellido2,
                    entity.Direccion,
                    entity.Telefono,
                    entity.FechaNacimiento,

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(ClientesEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarCliente", new
                {
                    entity.IdCliente,

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
