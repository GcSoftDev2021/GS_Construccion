using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS_Contruccion.App.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empresa
        public ActionResult Empleado()
        {
            return View();
        }

        public ActionResult Crear_Empleado()
        {
            return View();
        }

        public ActionResult Editar_Empleado()
        {
            return View();
        }

        public ActionResult Lista_Empleados()
        {
            return View();
        }

        public ActionResult Crear_Prestamo()
        {
            return View();
        }

        public ActionResult Editar_Prestamo()
        {
            return View();
        }

        public ActionResult Lista_Prestamos()
        {
            return View();
        }
    }
}