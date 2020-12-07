using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDeSangueWeb.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BancoDeSangueWeb.Controllers
{
    public class EstoqueController : Controller
    {
        public readonly EstoqueSangueDAO _estoqueSangueDAO;

        public EstoqueController(EstoqueSangueDAO estoqueSangueDAO)
        {
            _estoqueSangueDAO = estoqueSangueDAO;
            //_estoqueSangueDAO.CriarEstoqueSangue();
        }

        public IActionResult Index()
        {
            return View(_estoqueSangueDAO.Listar());
        }
    }
}
