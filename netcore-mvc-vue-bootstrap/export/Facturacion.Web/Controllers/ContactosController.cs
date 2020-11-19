using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using $ext_safeprojectname$.Entities;
using $ext_safeprojectname$.Entities.ViewModels;
using $ext_safeprojectname$.Business.Interfaces;
using $safeprojectname$.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace $safeprojectname$.Controllers
{
    public class ContactosController : Controller
    {
        private readonly IContactos contactos;
        private readonly ILogger<ContactosController> logger;

        public ContactosController(IContactos contactos, ILogger<ContactosController> logger)
        {
            this.contactos = contactos;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetClientesGrid([FromBody] GridRequest<ContactosFilters> gridRequest)
        {
            var results = contactos.GetClientes(gridRequest);

            var gridResponse = gridRequest.GetGridResponse(results);

            return Json(gridResponse);
        }
    }
}
