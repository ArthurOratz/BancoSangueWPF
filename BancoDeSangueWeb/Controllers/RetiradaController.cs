using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangueWeb.DAL;
using BancoDeSangueWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BancoDeSangueWeb.Controllers
{
    public class RetiradaController : Controller
    {
        private readonly RetiradaDAO _retiradaDAO;
        private readonly HospitalDAO _hospitalDAO;
        private readonly TipoSanguineoDAO _tipoSanguineoDAO;
        private readonly EstoqueSangueDAO _estoqueSangueDAO;

        public RetiradaController(RetiradaDAO retiradaDAO, HospitalDAO hospitalDAO, TipoSanguineoDAO tipoSanguineoDAO, EstoqueSangueDAO estoqueSangueDAO)
        {
            _retiradaDAO = retiradaDAO;
            _hospitalDAO = hospitalDAO;
            _tipoSanguineoDAO = tipoSanguineoDAO;
            _estoqueSangueDAO = estoqueSangueDAO;
        }

        public IActionResult Index()
        {
            return View(_retiradaDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Hospitais = new SelectList(_hospitalDAO.Listar(), "Id", "Nome");
            ViewBag.TiposSanguineos = new SelectList(_tipoSanguineoDAO.Listar(), "Id", "");
            return View();
        }

        //public IActionResult Editar(int Id)
        //{
        //    return View(_retiradaDAO.BuscarPorId(Id));
        //}

        [HttpPost]
        public IActionResult Cadastrar(Retirada retirada)
        {
            if (ModelState.IsValid)
            {
                    if (_retiradaDAO.Cadastrar(retirada))
                    {
                        return RedirectToAction("Index", "Retirada");
                    }
                    ModelState.AddModelError("", "Não há essa quantia de sangue disponivel");
            }

            ViewBag.Hospitais = new SelectList(_hospitalDAO.Listar(), "Id", "Nome");
            ViewBag.TiposSanguineos = new SelectList(_tipoSanguineoDAO.Listar(), "Id", "");
            return View(retirada);

        }

        //[HttpPost]
        //public IActionResult Editar(Retirada retirada)
        //{
        //    return RedirectToAction("Index", "Retirada");
        //}

        //public IActionResult Remover(int id)
        //{
        //    _retiradaDAO.Remover(id);
        //    return RedirectToAction("Index", "Retirada");
        //}
    }
}
