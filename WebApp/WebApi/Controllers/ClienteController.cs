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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteEntity>> Get()
        {
            try
            {
                return await clienteService.Get();
            }
            catch (Exception ex)
            {

                return new List<ClienteEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<ClienteEntity> Get(int id)
        {
            try
            {
                return await clienteService.GetById(new ClienteEntity { IdCliente = id });
            }
            catch (Exception ex)
            {

                return new ClienteEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(ClienteEntity entity)
        {
            try
            {
                return await clienteService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(ClienteEntity entity)
        {
            try
            {
                return await clienteService.Update(entity);
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
                return await clienteService.Delete(new ClienteEntity() { IdCliente = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


    }
}
