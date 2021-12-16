using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Usuario
{
    public class GridModel : PageModel
    {
        private readonly IUsuariosService usuariosService;

        public GridModel(IUsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }

        public IEnumerable<UsuariosEntity> GridList { get; set; } = new List<UsuariosEntity>();

        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await usuariosService.Get();


                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

    }
}