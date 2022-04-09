using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Contacto
{
    public class GridModel : PageModel
    {
        private readonly IContactoService contacto;

        public GridModel(IContactoService contacto)
        {
            this.contacto = contacto;
        }

        public IEnumerable<ContactoEntity> GridList { get; set; } = new List<ContactoEntity>();

        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await contacto.GET();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<JsonResult> OnDeleteEliminar(int id)
        {

            try
            {
                var result = await contacto.DELETE(new()
                { IdProveedor = id });

              
                return new JsonResult(result);
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
            }

        }
    }
}
