"use strict";
var GridContacto;
(function (GridContacto) {
    /*Mostrar el modal de confirmación*/
    function OnclickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                Loading.fire("Borrando");
                App.AxiosProvider.EliminarContacto(id).then(function (data) {
                    Loading.close();
                    if (data.CodeError == 0) {
                        Toast.fire({ title: "El registro se elimino correctamente", icon: "success" }).
                            then(function () { return window.location.reload(); });
                    }
                    else {
                        Toast.fire({ title: data.MsgError, icon: "error" });
                    }
                });
            }
        });
    }
    GridContacto.OnclickEliminar = OnclickEliminar;
    /*Datable*/
    $("#GridView").DataTable();
})(GridContacto || (GridContacto = {}));
//# sourceMappingURL=Grid.js.map