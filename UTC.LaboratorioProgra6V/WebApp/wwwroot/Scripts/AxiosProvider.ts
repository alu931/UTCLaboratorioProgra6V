
namespace App.AxiosProvider   {

    export const GuardarEmpleado = () => axios.get<DBEntity>("aplicacion").then(({data})=>data );


}




