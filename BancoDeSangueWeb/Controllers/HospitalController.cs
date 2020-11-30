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
            ViewBag.ListaHospitais = _hospitalDAO.Listar();
            return View();
        }

        public IActionResult Cadastrar() => View();
        [HttpPost]
        public IActionResult Cadastrar(string Nome, string Endereco, string Responsavel)
        {
            Hospital hospital = new Hospital
            {
                Nome = Nome,
                Endereco = Endereco,
                Nome_Responsavel = Responsavel,
            };

            _hospitalDAO.Cadastrar(hospital);
            return RedirectToAction("Index", "Hospital");
        }


        public IActionResult Remover(int id)
        {
            _hospitalDAO.Remover(id);
            return RedirectToAction("Index", "Hospital");
        }

        [HttpPost]
        public IActionResult Editar(int Id, string Nome, string Endereco, string responsavel)
        {
            Hospital hospital = _hospitalDAO.BurcarPorId(Id);
            hospital.Nome = Nome;
            hospital.Endereco = Endereco;
            hospital.Nome_Responsavel = responsavel;

            _hospitalDAO.Editar(hospital);
            return View();
        }

    }
}
