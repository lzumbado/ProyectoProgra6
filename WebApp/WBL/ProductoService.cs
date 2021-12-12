﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface IProductoService
    {
        Task<DBEntity> Create(ProductoEntity entity);
        Task<DBEntity> Delete(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> Get();
        Task<ProductoEntity> GetById(ProductoEntity entity);
        Task<DBEntity> Update(ProductoEntity entity);

        Task<IEnumerable<ProductoEntity>> GetLista();
    }

    public class ProductoService : IProductoService
    {
        private readonly IDataAccess sql;

        public ProductoService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Metodo Get


        public async Task<IEnumerable<ProductoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<ProductoEntity, CategoriaEntity>("ObtenerProducto", "IdProducto,IdCategoria");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<IEnumerable<ProductoEntity>> GetLista()
        {

            try
            {
                var result = sql.QueryAsync<ProductoEntity>("ObtenerProducto");

                return await result;
            }
            catch (Exception EX)
            {

                throw;
            }
        }

        //Metodo GetById
        public async Task<ProductoEntity> GetById(ProductoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<ProductoEntity>("ObtenerProducto", new
                { entity.IdProducto });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Create

        public async Task<DBEntity> Create(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("InsertarProducto", new
                {
                    entity.IdProducto,
                    entity.NombreProducto,                  
                    entity.CantidadDisponible,
                    entity.Caracteristicas,
                    entity.Estado,
                    entity.IdCategoria



                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Update
        public async Task<DBEntity> Update(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("ActualizarProducto", new
                {
                    entity.IdProducto,
                    entity.NombreProducto,                    
                    entity.CantidadDisponible,
                    entity.Caracteristicas,
                    entity.Estado,
                    entity.IdCategoria


                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo Delete
        public async Task<DBEntity> Delete(ProductoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("EliminarProducto", new
                {
                    entity.IdProducto,



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
