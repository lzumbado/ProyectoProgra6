﻿
namespace App.AxiosProvider   {

   
    export const CategoriaEliminar = (id) => axios.delete<DBEntity>("Categoria/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const CategoriaGuardar = (entity) => axios.post<DBEntity>("Categoria/Edit", entity).then(({ data }) => data);

    export const EmpleadoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Empleado/" + id).then(({ data }) => data);
    export const EmpleadoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Empleado", entity).then(({ data }) => data);
    export const EmpleadoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Empleado", entity).then(({ data }) => data);


}




