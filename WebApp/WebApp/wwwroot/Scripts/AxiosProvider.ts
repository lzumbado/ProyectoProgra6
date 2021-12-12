
namespace App.AxiosProvider   {

   
    export const CategoriaEliminar = (id) => axios.delete<DBEntity>("Categoria/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => axios.post<DBEntity>("Categoria/Edit", entity).then(({ data }) => data);

    export const ClienteEliminar = (id) => axios.delete<DBEntity>("Cliente/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ClienteGuardar = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);

    export const ProductoEliminar = (id) => axios.delete<DBEntity>("Producto/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ProductoGuardar = (entity) => axios.post<DBEntity>("Producto/Edit", entity).then(({ data }) => data);

    export const SeguridadEliminar = (id) => axios.delete<DBEntity>("Seguridad/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const SeguridadGuardar = (entity) => axios.post<DBEntity>("Seguridad/Edit", entity).then(({ data }) => data);

    export const PedidoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Pedido/" + id).then(({ data }) => data);
    export const PedidoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Pedido", entity).then(({ data }) => data);
    export const PedidoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Pedido", entity).then(({ data }) => data);


}




