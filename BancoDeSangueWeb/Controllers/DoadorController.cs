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
    public class DoadorController : Controller
    {
        private readonly DoadorDAO _doadorDAO;
        private readonly TipoSanguineoDAO _tipoSanguineoDAO;

        public DoadorController(DoadorDAO doadorDAO, TipoSanguineoDAO tipoSanguineoDAO)
        {
            _doadorDAO = doadorDAO;
            _tipoSanguineoDAO = tipoSanguineoDAO;

        }

        public IActionResult Index(int id)
        {
            ViewBag.listaTipoSanguineo = _tipoSanguineoDAO.Listar();
            return View(id > 0 ? _doadorDAO.ListarPorTipoSanguineo(id) : _doadorDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.TiposSanguineos = new SelectList(_tipoSanguineoDAO.Listar(), "Id", "");
            return View();
        }

        public IActionResult Editar(int id)
        {
            return View(_doadorDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Doador doador)
        {
            if (ModelState.IsValid)
            {
                doador.TipoSanguineo = _tipoSanguineoDAO.BuscarPorId(doador.TipoSanguineoId);

                if (_doadorDAO.Cadastrar(doador))
                {
                    return RedirectToAction("Index", "Doador");
                }
                ModelState.AddModelError("", "Já existe um  doador com esse CPF!");
            }
            ViewBag.TiposSanguineos = new SelectList(_tipoSanguineoDAO.Listar(), "Id", "");
            return View(doador);
        }


        [HttpPost]
        public IActionResult Editar(Doador doador)
        {

            if (ModelState.IsValid)
            {
                var oldDoador = _doadorDAO.BuscarPorId(doador.Id);
                oldDoador.Nome = doador.Nome;
                oldDoador.Cpf = doador.Cpf;
                oldDoador.Email = doador.Email;
                oldDoador.Telefone = doador.Telefone;
                _doadorDAO.Editar(oldDoador);
                //return View();
            }
            return RedirectToAction("Index", "Doador");

        }

    }
}
