using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }


        public async Task<IEnumerable<PedidoEntity>> PedidoGet()
        {

            var result = await client.ServicioGetAsync<IEnumerable<PedidoEntity>>("api/Pedido");
            return result;

        }


        public async Task<PedidoEntity> PedidoGetById(int id)
        {
            var result = await client.ServicioGetAsync<PedidoEntity>("api/Pedido/" + id);

            if (result.CodeError is not 0) throw new Exception(result.MsgError);

            return result;

        }

        public async Task<IEnumerable<ProductoEntity>> ProductoGetLista()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto/Lista");
            return result;

        }

        public async Task<IEnumerable<ClienteEntity>> ClienteGetLista()
        {

            var result = await client.ServicioGetAsync<IEnumerable<ClienteEntity>>("api/Cliente/Lista");
            return result;

        }

        public async Task<UsuariosEntity> UsuarioLogin(UsuariosEntity entity)
        {

            var result = await client.ServicioPostAsync<UsuariosEntity>("api/Usuarios/Login", entity);

            return result;
        }
    }
}
