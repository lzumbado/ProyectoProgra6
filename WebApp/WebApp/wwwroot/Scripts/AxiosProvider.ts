﻿
namespace App.AxiosProvider   {

   
    export const CategoriaEliminar = (id) => axios.delete<DBEntity>("Categoria/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => axios.post<DBEntity>("Categoria/Edit", entity).then(({ data }) => data);

    export const ClienteEliminar = (id) => axios.delete<DBEntity>("Cliente/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ClienteGuardar = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);

    export const ProductoEliminar = (id) => axios.delete<DBEntity>("Producto/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const ProductoGuardar = (entity) => axios.post<DBEntity>("Producto/Edit", entity).then(({ data }) => data);

    export const EmpleadoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Empleado/" + id).then(({ data }) => data);
    export const EmpleadoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Empleado", entity).then(({ data }) => data);
    export const EmpleadoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Empleado", entity).then(({ data }) => data);


}




