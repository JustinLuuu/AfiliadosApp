using Microsoft.AspNetCore.Mvc;
using Prueba_Tecnica_ARS.Models;
using Prueba_Tecnica_ARS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Controllers
{
    public class PlanesController : Controller
    {
        private readonly Afiliados afiliadosData;
        private readonly Planes planesData;
        private readonly Estatus estatusData;

        public PlanesController()
        {
            afiliadosData = new Afiliados();
            planesData = new Planes();
            estatusData = new Estatus();
        }

        [HttpGet]
        public IActionResult Index()
        {
            CargarRecursos();
            var listadoPlanes = planesData.ObtenerListado();
            return View(listadoPlanes);
        }

        [HttpGet]
        public IActionResult CrearPlan()
        {
            CargarRecursos();
            return View();
        }

        [HttpPost]
        public IActionResult CrearPlan(Planes plan)
        {
            plan.Insertar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ActualizarPlan(int idPlan)
        {
            CargarRecursos();
            var plan = planesData.ObtenerPlanPorId(idPlan);
            return plan.Id != default ? View(plan) : NotFound();        
        }

        [HttpPost]
        public IActionResult ActualizarPlan(Planes plan)
        {
            plan.Actualizar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CambiarEstatusPlan(int idPlan)
        {
            var plan = planesData.ObtenerPlanPorId(idPlan);
            plan.Id_Estatus = (plan.Id_Estatus == (int)ConstEstatus.Activo ?
            (int)ConstEstatus.Inactivo : (int)ConstEstatus.Activo);

            plan.Actualizar();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult VerDetallePlan(int idPlan)
        {
            CargarRecursos();
            var listadoAfiliadosConPlan = afiliadosData.ObtenerAfiliadosPorPlan(idPlan);
            ViewBag.PlanNombre = planesData.ObtenerPlanPorId(idPlan)?.Nombre;
            return View(listadoAfiliadosConPlan);
        }
        
        private void CargarRecursos()
        {
            ViewData["Planes"] = planesData.ObtenerListado();
            ViewData["Estatus"] = estatusData.ObtenerListado();
        }
    }
}
