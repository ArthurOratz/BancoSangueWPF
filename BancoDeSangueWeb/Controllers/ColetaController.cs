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
    public class ColetaController : Controller
    {
        private readonly ColetaDAO _coletaDAO;
        private readonly DoadorDAO _doadorDAO;
        private readonly FuncionarioDAO _funcionarioDAO;
        private readonly EstoqueSangueDAO _estoqueSangueDAO;

        public ColetaController(ColetaDAO coletaDAO, DoadorDAO doadorDAO, FuncionarioDAO funcionarioDAO, EstoqueSangueDAO estoqueSangueDAO)
        {
            _coletaDAO = coletaDAO;
            _doadorDAO = doadorDAO;
            _funcionarioDAO = funcionarioDAO;
            _estoqueSangueDAO = estoqueSangueDAO;
        }

        public IActionResult Index()
        {
            return View(_coletaDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Doadores = new SelectList(_doadorDAO.Listar(), "Id", "");
            ViewBag.Funcionarios = new SelectList(_funcionarioDAO.Listar(), "Id", "Nome");

            return View();
        }

        //public IActionResult Editar(int Id)
        //{
        //    return View(_coletaDAO.BuscarPorId(Id));
        //}

        [HttpPost]
        public IActionResult Cadastrar(Coleta coleta)
        {
            if (ModelState.IsValid)
            {
                if (_coletaDAO.Cadastrar(coleta))
                {
                    _estoqueSangueDAO.AumentaEstoque(_doadorDAO.BuscarPorId(coleta.DoadorId).TipoSanguineoId, coleta.Quantidade);
                    return RedirectToAction("Index", "Coleta");
                }
                ModelState.AddModelError("", "O doador deve aguardar o periodo necessario para doar sangue novamente");
            }

            ViewBag.Doadores = new SelectList(_doadorDAO.Listar(), "Id", "");
            ViewBag.Funcionarios = new SelectList(_funcionarioDAO.Listar(), "Id", "Nome");
            return View(coleta);

        }

        //[HttpPost]
        //public IActionResult Editar(Coleta coleta)
        //{
        //    return RedirectToAction("Index", "Retirada");
        //}

        //public IActionResult Remover(int id)
        //{
        //    _coletaDAO.Remover(id);
        //    return RedirectToAction("Index", "Retirada");
        //}
    }
}
