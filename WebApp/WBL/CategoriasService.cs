using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICategoriasService 
    {
        Task<IEnumerable<CategoriasEntity>> GetLista();
    }

    public class CategoriasService : ICategoriasService
    {
        private readonly IDataAccess sql;

        public CategoriasService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<CategoriasEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CategoriasEntity>("ObtenerCategoria");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<CategoriasEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<CategoriasEntity>("ObtenerCategoria");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<CategoriasEntity> GetById(CategoriasEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CategoriasEntity>("ObtenerCategoria", new
                { entity.IdCategoria });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(CategoriasEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarCategoria", new
                {
                    entity.IdCategoria,
                    entity.Categoria,
                   
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(CategoriasEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarCategoria", new
                {
                    entity.IdCategoria,
                    entity.Categoria,             


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(CategoriasEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarCategoria", new
                {
                    entity.IdCategoria,

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
