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
    public class LocalController : Controller
    {    
        [Inject]
        public IRepositorioEmpresa RepositorioEmpresa { get; set; }
        
        private IRepositorioGenerico<Empresa> _repositorio;

        [Inject]
        public LocalController(IRepositorioGenerico<Empresa> repositorio)
        {
            _repositorio = repositorio;
        }

        //
        public ActionResult Detalhe(int id)
        {

            var empresa = EmpresaViewModel.EmpresaEntityToViewModel(_repositorio.Get(id));


            return View(empresa);
        }
        
    }
}
