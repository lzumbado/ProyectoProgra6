"use strict";
var EmpleadoGrid;
(function (EmpleadoGrid) {
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro?", "Eliminar", "warning", "#3085d6", "d33")
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando...");
                App.AxiosProvider.EmpleadoEliminar(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "Se elimino correctamente", icon: "success" }).then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    EmpleadoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(EmpleadoGrid || (EmpleadoGrid = {}));
//# sourceMappingURL=Grid.js.map