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
    public class SeguridadController : ControllerBase
    {
        private readonly ISeguridadService seguridadService;

        public SeguridadController(ISeguridadService seguridadService)
        {
            this.seguridadService = seguridadService;
        }

        [HttpGet]
        public async Task<IEnumerable<SeguridadEntity>> Get()
        {
            try
            {
                return await seguridadService.Get();
            }
            catch (Exception ex)
            {

                return new List<SeguridadEntity>();
            }


        }

        [HttpGet("{id}")]
        public async Task<SeguridadEntity> Get(int id)
        {
            try
            {
                return await seguridadService.GetById(new SeguridadEntity { IdSeguridad = id });
            }
            catch (Exception ex)
            {

                return new SeguridadEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPost]
        public async Task<DBEntity> Create(SeguridadEntity entity)
        {
            try
            {
                return await seguridadService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }

        [HttpPut]
        public async Task<DBEntity> Update(SeguridadEntity entity)
        {
            try
            {
                return await seguridadService.Update(entity);
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
                return await seguridadService.Delete(new SeguridadEntity() { IdSeguridad = id });
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }


        }


    }
}
