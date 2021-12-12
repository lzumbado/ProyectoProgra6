"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        AxiosProvider.CategoriaEliminar = function (id) { return axios.delete("Categoria/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaGuardar = function (entity) { return axios.post("Categoria/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteEliminar = function (id) { return axios.delete("Cliente/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteGuardar = function (entity) { return axios.post("Cliente/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoEliminar = function (id) { return axios.delete("Producto/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoGuardar = function (entity) { return axios.post("Producto/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        //export const EmpleadoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Empleado/" + id).then(({ data }) => data);
        //export const EmpleadoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Empleado", entity).then(({ data }) => data);
        //export const EmpleadoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Empleado", entity).then(({ data }) => data);
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map