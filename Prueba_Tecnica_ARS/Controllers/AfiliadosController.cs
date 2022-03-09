using Microsoft.AspNetCore.Mvc;
using Prueba_Tecnica_ARS.Models;
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
        public IActionResult SwitchActivarAfiliado(int idAfiliado)
        {
            afiliadosData.SwitchActivar(idAfiliado);
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
            var afiliadoActualizar = afiliadosData.ObtenerAfiliadoPorId(afiliadoId);
            afiliadoActualizar.Monto_Consumido += montoSumar;
            afiliadoActualizar.Actualizar();
            return RedirectToAction("Index");
        }

        private void CargarRecursos()
        {
            ViewData["Planes"] = planesData.ObtenerListado();
            ViewData["Estatus"] = estatusData.ObtenerListado();
        }
    }
}
