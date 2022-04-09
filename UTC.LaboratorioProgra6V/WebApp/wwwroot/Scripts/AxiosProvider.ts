
namespace App.AxiosProvider   {

    export const GuardarContacto = (entity) => axios.post<DBEntity>("Contacto/Edit", entity).then(({data})=>data );
    export const EliminarContacto = (id) => axios.delete<DBEntity>("Contacto/Grid?handler=Eliminar&id=" + id ).then(({ data }) => data);


    
}




