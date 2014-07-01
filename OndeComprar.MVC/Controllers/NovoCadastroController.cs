using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using OndeComprar.MVC.Models;
using OndeComprar.Model;
using OndeComprar.Model.Interfaces;

namespace OndeComprar.MVC.Controllers
{
    public class NovoCadastroController : Controller
    {
        private IRepositorioGenerico<Empresa> _repositorio;

        [Inject]
        public NovoCadastroController(IRepositorioGenerico<Empresa> repositorio)
        {
            _repositorio = repositorio;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(EmpresaViewModel empresa)
        {
            var empresaEntity = EmpresaViewModel.EmpresaViewModelToEntity(empresa);

            _repositorio.Add(empresaEntity);

            return RedirectToAction("Index", "Empresa");
            
        }
    }
}
