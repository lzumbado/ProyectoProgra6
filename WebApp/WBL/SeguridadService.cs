using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ISeguridadService
    {
        Task<DBEntity> Create(SeguridadEntity entity);
        Task<DBEntity> Delete(SeguridadEntity entity);
        Task<IEnumerable<SeguridadEntity>> Get();
        Task<SeguridadEntity> GetById(SeguridadEntity entity);
        Task<DBEntity> Update(SeguridadEntity entity);

        Task<IEnumerable<SeguridadEntity>> GetLista();
    }

    public class SeguridadService : ISeguridadService
    {
        private readonly IDataAccess sql;

        public SeguridadService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<SeguridadEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<SeguridadEntity>("ObtenerSeguridad");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<SeguridadEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<SeguridadEntity>("ObtenerSeguridad");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<SeguridadEntity> GetById(SeguridadEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<SeguridadEntity>("ObtenerSeguridad", new
                { entity.IdSeguridad });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(SeguridadEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarSeguridad", new
                {
                    entity.IdSeguridad,
                    entity.NombreUsuario,
                    entity.Usuario,
                    entity.Contrasena

                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(SeguridadEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarSeguridad", new
                {
                    entity.IdSeguridad,
                    entity.NombreUsuario,
                    entity.Usuario,
                    entity.Contrasena


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(SeguridadEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarSeguridad", new
                {
                    entity.IdSeguridad,

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
