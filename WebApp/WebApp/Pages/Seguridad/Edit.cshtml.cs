using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Seguridad
{
    public class EditModel : PageModel
    {
        private readonly ISeguridadService seguridadService;


        public EditModel(ISeguridadService seguridadService)
        {
            this.seguridadService = seguridadService;

        }

        [BindProperty]
        [FromBody]

        public SeguridadEntity Entity { get; set; } = new SeguridadEntity();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await seguridadService.GetById(new() { IdSeguridad = id });
                }


                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

        public async Task<IActionResult> OnPost()
        {

            try
            {
                var result = new DBEntity();
                if (Entity.IdSeguridad.HasValue)
                {
                    result = await seguridadService.Update(Entity);


                }
                else
                {
                    result = await seguridadService.Create(Entity);

                }

                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }


        }

    }
}
