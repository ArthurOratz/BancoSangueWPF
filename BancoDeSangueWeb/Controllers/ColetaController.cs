using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangueWeb.DAL;
using BancoDeSangueWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangueWeb.Controllers
{
    public class ColetaController : Controller
    {
        private readonly ColetaDAO _coletaDAO;

        public ColetaController(ColetaDAO coletaDAO) => _coletaDAO= coletaDAO;


        public IActionResult Index()
        {
            return View(_coletaDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int Id)
        {
            return View(_coletaDAO.BuscarPorId(Id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Coleta coleta)
        {
            if (ModelState.IsValid)
            {
                if (_coletaDAO.Cadastrar(coleta))
                {
                    return RedirectToAction("Index", "Coleta");
                }
                ModelState.AddModelError("", "Mensagem de erro");
            }
            return View(coleta);

        }

        [HttpPost]
        public IActionResult Editar(Coleta coleta)
        {
            return RedirectToAction("Index", "Retirada");
        }

        public IActionResult Remover(int id)
        {
            _coletaDAO.Remover(id);
            return RedirectToAction("Index", "Retirada");
        }
    }
}
