using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangueWeb.DAL;
using BancoDeSangueWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangueWeb.Controllers
{
    public class HospitalController : Controller
    {
        private readonly HospitalDAO _hospitalDAO;

        public HospitalController(HospitalDAO hospitalDAO) => _hospitalDAO = hospitalDAO;


        public IActionResult Index()
        {
            ViewBag.Title = "Lista de Hospitais";
            return View(_hospitalDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Title = "Cadastro de Hospital";
         return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Hospital hospital)
        {

            if (ModelState.IsValid)
            {
                if (_hospitalDAO.Cadastrar(hospital))
                {
                    return RedirectToAction("Index", "Hospital");
                }
                ModelState.AddModelError("", "Já existe um  hospital com esse nome cadastrado!");
            }
            return View(hospital);

        }


        public IActionResult Remover(int id)
        {
            _hospitalDAO.Remover(id);
            return RedirectToAction("Index", "Hospital");
        }

        public IActionResult Editar(int Id)
        {
            return View(_hospitalDAO.BuscarPorId(Id));
        }
        [HttpPost]
        public IActionResult Editar(Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                var oldHosp = _hospitalDAO.BuscarPorId(hospital.Id);
                hospital.CriadoEm = oldHosp.CriadoEm;
                _hospitalDAO.Editar(hospital);
                //return View();
            }
            return RedirectToAction("Index", "Hospital");

        }

    }
}
