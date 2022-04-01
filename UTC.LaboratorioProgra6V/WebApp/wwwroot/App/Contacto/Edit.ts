namespace ContactoEdit {

    var Formulario = new Vue(
        {
            data:
            {
                Formulario: "#FormEdit"  // nombre del id que se le dio al form en el Edit

            },
            mounted() {
                CreateValidator(this.Formulario);

            }

        });

    Formulario.$mount("#AppEdit");



}