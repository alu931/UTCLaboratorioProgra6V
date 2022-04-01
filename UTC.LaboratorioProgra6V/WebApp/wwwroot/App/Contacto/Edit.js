"use strict";
var ContactoEdit;
(function (ContactoEdit) {
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit" // nombre del id que se le dio al form en el Edit
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(ContactoEdit || (ContactoEdit = {}));
//# sourceMappingURL=Edit.js.map