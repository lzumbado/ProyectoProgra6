namespace PedidoEdit {
    var Entity = $("#AppEdit").data("entity");

    var Formulario = new Vue(
        {
            data:
            {
                Formulario: "#FormEdit",
                Entity: Entity
            },

            methods: {

                ClienteServicio(entity) {
                    console.log(entity);
                    if (entity.IdPedido == null) {
                        return App.AxiosProvider.PedidoGuardar(entity);

                    } else {
                        return App.AxiosProvider.PedidoActualizar(entity);

                    }
                },

                Save() {

                    if (BValidateData(this.Formulario)) {
                        Loading.fire("Guardando");

                        this.ClienteServicio(this.Entity).then(data => {
                            Loading.close();

                            if (data.CodeError == 0) {
                                Toast.fire({ title: "Se guardo correctamente", icon: "success" })
                                    .then(() => window.location.href = "Pedido/Grid");
                            }
                            else {
                                Toast.fire({ title: data.MsgError, icon: "error" });
                            }


                        }).catch(c => console.log(c));

                    }
                    else {
                        Toast.fire({ title: "Por favor complete los campos requeridos" });

                    }

                }
            },





            mounted() {
                CreateValidator(this.Formulario)
            },
            created() {
                this.Entity.FechaPedido = this.Entity.FechaPedido?.slice(0, 10);
            }
        }

    );

    Formulario.$mount("#AppEdit")

}