using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;

namespace WebApp.Pages.Pedido
{
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;
        

        public EditModel(ServiceApi service)
        {
            this.service = service;
           
        }


        [BindProperty]
        public PedidoEntity Entity { get; set; } = new PedidoEntity();

        public IEnumerable<ProductoEntity> ProductoLista { get; set; } = new List<ProductoEntity>();
        public IEnumerable<ClienteEntity> ClienteLista { get; set; } = new List<ClienteEntity>();

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await service.PedidoGetById(id.Value);
                }

                //ProductoLista = await service.ProductoGetLista();
               // ClienteLista = await service.ClienteGetLista();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }
    }
}
