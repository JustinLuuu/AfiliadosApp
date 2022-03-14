using Microsoft.AspNetCore.Mvc;
using Prueba_Tecnica_ARS.Models;
using Prueba_Tecnica_ARS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Controllers
{
    public class AfiliadosController : Controller
    {
        private readonly Afiliados afiliadosData;
        private readonly Planes planesData;
        private readonly Estatus estatusData;

        public AfiliadosController()
        {
            afiliadosData = new Afiliados();
            planesData = new Planes();
            estatusData = new Estatus();
        }


        [HttpGet]
        public IActionResult Index()
        {
            CargarRecursos();
            var listadoAfiliados = afiliadosData.ObtenerListado();
            return View(listadoAfiliados);
        }

        [HttpGet]
        public IActionResult CrearAfiliado()
        {
            CargarRecursos();
            return View();
        }

        [HttpPost]
        public IActionResult CrearAfiliado(Afiliados afiliado)
        {
            afiliado.Insertar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ActualizarAfiliado(int idAfiliado)
        {
            CargarRecursos();
            var afiliado = afiliadosData.ObtenerAfiliadoPorId(idAfiliado);
            return afiliado.Id != default ? View(afiliado) : NotFound();
        }

        [HttpPost]
        public IActionResult ActualizarAfiliado(Afiliados afiliado)
        {
            afiliado.Actualizar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CambiarEstatusAfiliado(int idAfiliado)
        {
            var afiliado = afiliadosData.ObtenerAfiliadoPorId(idAfiliado);
            afiliado.Id_Estatus = (afiliado.Id_Estatus == (int)ConstEstatus.Activo ?
            (int)ConstEstatus.Inactivo : (int)ConstEstatus.Activo);

            afiliado.Actualizar();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult ActualizarMontoConsumido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ActualizarMontoConsumido(int afiliadoId, decimal montoSumar)
        {
            var afiliado = afiliadosData.ObtenerAfiliadoPorId(afiliadoId);
            afiliado.Monto_Consumido += montoSumar;
            afiliado.Actualizar();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ConsultaMasivaAfiliados()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConsultaMasivaAfiliados (string nombres, string apellidos, string cedula)
        {
            CargarRecursos();
            var afiliadosListadoFiltrar = afiliadosData.ObtenerListado() as List<Afiliados>;

            if(!String.IsNullOrEmpty(nombres))
            {
                afiliadosListadoFiltrar = afiliadosListadoFiltrar.Where(x => x.Nombres == nombres).ToList();
            }

            if (!String.IsNullOrEmpty(apellidos))
            {
                afiliadosListadoFiltrar = afiliadosListadoFiltrar.Where(x => x.Apellidos == apellidos).ToList();
            }

            if (!String.IsNullOrEmpty(cedula))
            {
                afiliadosListadoFiltrar = afiliadosListadoFiltrar.Where(x => x.Cedula == cedula).ToList();
            }

            return View(afiliadosListadoFiltrar);
        }

        private void CargarRecursos()
        {
            ViewData["Planes"] = planesData.ObtenerListado();
            ViewData["Estatus"] = estatusData.ObtenerListado();
        }
    }
}
