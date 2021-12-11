using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICategoriaService 
    {
        Task<DBEntity> Create(CategoriaEntity entity);
        Task<DBEntity> Delete(CategoriaEntity entity);
        Task<IEnumerable<CategoriaEntity>> Get();
        Task<CategoriaEntity> GetById(CategoriaEntity entity);
        Task<DBEntity> Update(CategoriaEntity entity);

        Task<IEnumerable<CategoriaEntity>> GetLista();
    }

    public class CategoriaService : ICategoriaService
    {
        private readonly IDataAccess sql;

        public CategoriaService(IDataAccess _sql)
        {
            sql = _sql;
        }


        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<CategoriaEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<CategoriaEntity>("ObtenerCategoria");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<CategoriaEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<CategoriaEntity>("ObtenerCategoria");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<CategoriaEntity> GetById(CategoriaEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<CategoriaEntity>("ObtenerCategoria", new
                { entity.IdCategoria });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(CategoriaEntity entity)
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
        public async Task<DBEntity> Update(CategoriaEntity entity)
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
        public async Task<DBEntity> Delete(CategoriaEntity entity)
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
