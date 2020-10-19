using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solution.UI.Services;

namespace Solution.UI.Controllers
{
    [Authorize]
    public class PaisController : Controller
    {

        public IRepositorioPais repo { get; }

        public PaisController(IRepositorioPais repositorio)
        {
            repo = repositorio;
        }
        public IActionResult Index()
        {
            return View(repo.ObtenerTodos());
        }
    }
}
