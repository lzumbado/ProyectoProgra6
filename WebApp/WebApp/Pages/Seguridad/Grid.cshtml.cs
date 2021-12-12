using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Seguridad
{
    public class GridModel : PageModel
    {
        private readonly ISeguridadService seguridadService;

        public GridModel(ISeguridadService seguridadService)
        {
            this.seguridadService = seguridadService;
        }

        public IEnumerable<SeguridadEntity> GridList { get; set; } = new List<SeguridadEntity>();

        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await seguridadService.Get();


                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnDeleteEliminar(int id)
        {

            try
            {
                var result = await seguridadService.Delete(new() { IdSeguridad = id });

                return new JsonResult(result);


            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }









    }
}
