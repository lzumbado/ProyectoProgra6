using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            this.pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<IEnumerable<PedidoEntity>> Get()
        {
            try
            {
                return await pedidoService.Get();
            }
            catch (Exception ex)
            {

                return new List<PedidoEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<PedidoEntity> Get(int id)
        {
            try
            {
                return await pedidoService.GetById(new PedidoEntity { IdPedido = id });
            }
            catch (Exception ex)
            {

                return new PedidoEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(PedidoEntity entity)
        {
            try
            {
                return await pedidoService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(PedidoEntity entity)
        {
            try
            {
                return await pedidoService.Update(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                return await pedidoService.Delete(new PedidoEntity() { IdPedido = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


    }
}
