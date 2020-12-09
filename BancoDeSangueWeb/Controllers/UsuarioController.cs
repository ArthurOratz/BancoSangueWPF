using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BancoDeSangueWeb.Models;

namespace BancoDeSangueWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioView = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioView == null)
            {
                return NotFound();
            }

            return View(usuarioView);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Senha,Id,CriadoEm,ConfirmacaoSenha")] UsuarioView usuarioView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioView);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioView = await _context.Usuario.FindAsync(id);
            if (usuarioView == null)
            {
                return NotFound();
            }
            return View(usuarioView);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Email,Senha,Id,CriadoEm")] UsuarioView usuarioView)
        {
            if (id != usuarioView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioViewExists(usuarioView.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioView);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioView = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioView == null)
            {
                return NotFound();
            }

            return View(usuarioView);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioView = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuarioView);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioViewExists(int id)
        {
            return _context.Usuario.Any(e => e.Id == id);
        }
    }
}
