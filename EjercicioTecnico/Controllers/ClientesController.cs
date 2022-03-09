using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EjercicioTecnico.Data;
using EjercicioTecnico.Models;

namespace EjercicioTecnico.Controllers
{
    public class ClientesController : Controller
    {
        private readonly EntityContext _context;

        public ClientesController(EntityContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            try
            {
                List<ClienteViewModel> model = new List<ClienteViewModel>();
                var paises = await _context.Pais.ToListAsync();
                //Para cargar los paises del combo
                ViewBag.Pais = paises;
                //Obtengo los datos de la base para luego trabajarlo desde memoria
                var tipo = await _context.Tipo.ToListAsync();
                var cliente = await _context.Cliente.ToListAsync();

                foreach(var item in cliente)
                {
                    var pais = paises.FirstOrDefault(m => m.Id == item.IdPais);
                    var entidad = tipo.FirstOrDefault(m => m.Id == item.IdTipo);
                    ClienteViewModel cliViewModel = new ClienteViewModel(item, pais.Nombre, entidad.Nombre);
                    model.Add(cliViewModel);
                }

                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveChanges([FromBody]Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(cliente);
                    await _context.SaveChangesAsync();
                    return Json("Ok");
                }
                return Json("No");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient([FromBody] int id)
        {
            try
            {
                var cliente = await _context.Cliente.FindAsync(id);
                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
