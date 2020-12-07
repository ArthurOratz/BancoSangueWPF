using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BancoDeSangueWeb.Models;
using BancoDeSangueWeb.DAL;

namespace BancoDeSangueWeb.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioDAO _funcionarioDAO;

        public FuncionarioController(FuncionarioDAO funcionarioDAO) => _funcionarioDAO = funcionarioDAO;

        public IActionResult Index()
        {
            ViewBag.Title = "Lista de Funcionarios";
            return View(_funcionarioDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Title = "Cadastro de Funcionário";
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View(_funcionarioDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                if (_funcionarioDAO.Cadastrar(funcionario))
                {
                    return RedirectToAction("Index", "Funcionario");
                }
                ModelState.AddModelError("", "Já existe um  funcionário com esse CPF!");
            }
            return View(funcionario);

        }


        [HttpPost]
        public IActionResult Editar(Funcionario funcionario)
        {

            if (ModelState.IsValid)
            {
                var oldFunc = _funcionarioDAO.BuscarPorId(funcionario.Id);
                oldFunc.Nome = funcionario.Nome;
                oldFunc.Cpf = funcionario.Cpf;
                oldFunc.Email= funcionario.Email;
                oldFunc.Telefone = funcionario.Telefone;
                _funcionarioDAO.Editar(oldFunc);
                //return View();
            }
            return RedirectToAction("Index", "Funcionario");

        }

    }
}
