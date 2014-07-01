using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using OndeComprar.Data.Config;
using OndeComprar.MVC.Models;
using OndeComprar.Model;
using OndeComprar.Model.Interfaces;


namespace OndeComprar.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IRepositorioGenerico<Empresa> _repositorioEmpresa;

        [Inject]
        public HomeController(IRepositorioGenerico<Empresa> repositorioEmpresa)
        {
            _repositorioEmpresa = repositorioEmpresa;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.Title = "Onde Comprar?";

            var empresa = _repositorioEmpresa.GetAll();
            var empresaVm = empresa.Select(x => new EmpresaViewModel()
            {
                EmpresaId = x.EmpresaId,
                Nome = x.Nome,
                Logotipo = x.Logradouro,
                TextoDestaque = x.TextoDestaque
            }).ToList();

            var home = new HomeViewModel {EmpresasDestaque = empresaVm};

            return View(home);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
