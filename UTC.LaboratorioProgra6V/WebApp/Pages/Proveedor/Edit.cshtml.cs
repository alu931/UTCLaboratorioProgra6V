using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Proveedores
{
    public class EditModel : PageModel
    {
        private readonly IProveedorService proveedor;

        public EditModel(IProveedorService proveedor)
        {
            this.proveedor = proveedor;
        }

        public void OnGet()
        {
        }
    }
}
