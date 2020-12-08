using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangueWeb.DAL;
using BancoDeSangueWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangueWeb.Controllers
{
    public class RetiradaController : Controller
    {
        private readonly RetiradaDAO _retiradaDAO;

        public RetiradaController(RetiradaDAO retiradaDAO) => _retiradaDAO = retiradaDAO;


        public IActionResult Index()
        {
            return View(_retiradaDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int Id)
        {
            return View(_retiradaDAO.BuscarPorId(Id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Retirada retirada)
        {
            if (ModelState.IsValid)
            {
                if (_retiradaDAO.Cadastrar(retirada))
                {
                    return RedirectToAction("Index", "Retirada");
                }
                ModelState.AddModelError("", "Mensagem de erro");
            }
            return View(retirada);

        }

        [HttpPost]
        public IActionResult Editar(Retirada retirada)
        {
            return RedirectToAction("Index", "Retirada");
        }

        public IActionResult Remover(int id)
        {
            _retiradaDAO.Remover(id);
            return RedirectToAction("Index", "Retirada");
        }
    }
}
