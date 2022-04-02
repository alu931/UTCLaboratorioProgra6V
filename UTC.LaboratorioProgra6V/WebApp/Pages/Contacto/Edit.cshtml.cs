using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Contacto
{
    public class EditModel : PageModel
    {
        private readonly IContactoService contacto;
        private readonly IProveedorService proveedor;

        public EditModel(IContactoService contacto, IProveedorService proveedor)
        {
            this.contacto = contacto;
            this.proveedor = proveedor;
        }

        [BindProperty(SupportsGet = true)] //para que no se filtre los ids en los url y evitar robo
        public int? id { get; set; }  //el signo es par que el campo permita nulos en el caso que se vaya a hacer un insert

        [BindProperty] //protege todo
        public ContactoEntity Entity { get; set; } = new ContactoEntity(); //prop para guardar los datos de la entidad
        public IEnumerable<ProveedorEntity> Proveedor { get; set; } = new List<ProveedorEntity>();
        //metodo edit
        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (id.HasValue)
                {
                    Entity = await contacto.GETBYID(new()
                    {
                        IdProveedor = id
                    });
                }

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        //metodo update insert
        public async Task<IActionResult>OnPostAsync()
        {
            try
            {
                //update
                if (Entity.IdContacto.HasValue) //si el idContacto tiene un valor (true) el metodo actuliza
                {
                    var result = await contacto.UPDATE(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se actualizo correctamente";

                }
                else //Si el idContacto no tiene valor (false) el metodo inserta
                {
                    var result = await contacto.CREATE(Entity);

                    if (result.CodeError != 0) throw new Exception(result.MsgError);
                    TempData["Msg"] = "Se inserto correctamente";
                }

                return RedirectToPage("Grid"); //hacer el grid
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }






        //*****************
    }
}
