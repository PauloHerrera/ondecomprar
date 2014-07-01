using System.Linq;
using System.Web.Mvc;
using Ninject;
using OndeComprar.MVC.Models;
using OndeComprar.Model;
using OndeComprar.Model.Interfaces;

namespace OndeComprar.MVC.Areas.Admin.Controllers
{
    public class EmpresaController : Controller
    {
        [Inject]
        public IRepositorioEmpresa RepositorioEmpresa { get; set; }
        
        private IRepositorioGenerico<Empresa> _repositorio;

        [Inject]
        public EmpresaController(IRepositorioGenerico<Empresa> repositorio)
        {
            _repositorio = repositorio;
        }

        //
        // GET: /Empresa/
        public ActionResult Index()
        {
            //Jeito 1
            //var empresa = RepositorioEmpresa.ListaEmpresas().Select(x => new EmpresaViewModel()
            //                                                                 {
            //                                                                     Nome = x.Nome,
            //                                                                     Logradouro = x.Logradouro
            //                                                                 }).ToList();

            var empresa = _repositorio.GetAll();
            var empresaVm = empresa.Select(x => new EmpresaViewModel()
                                                    {
                                                        EmpresaId = x.EmpresaId,
                                                        Nome = x.Nome,
                                                        Logotipo = x.Logradouro
                                                    }).ToList();
            return View(empresaVm);
        }

        //
        // GET: /Empresa/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Empresa/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Empresa/Create

        [HttpPost]
        public ActionResult Create(EmpresaViewModel empresa)
        {
            try
            {
                var empresaEntity = EmpresaViewModel.EmpresaViewModelToEntity(empresa);

                _repositorio.Add(empresaEntity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Empresa/Edit/5

        public ActionResult Edit(int id)
        {
            var empresa = _repositorio.Get(id);
            var empresaVm = EmpresaViewModel.EmpresaEntityToViewModel(empresa);

            return View(empresaVm);
        }

        //
        // POST: /Empresa/Edit/5

        [HttpPost]
        public ActionResult Edit(EmpresaViewModel empresa)
        {
            try
            {
                var empresaEntity = EmpresaViewModel.EmpresaViewModelToEntity(empresa);

                _repositorio.Update(empresaEntity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Empresa/Delete/5

        public ActionResult Delete(long id)
        {
           //TODO: try catch no delete
            _repositorio.Remove(id);

            return RedirectToAction("Index");
        }

        ////
        //// POST: /Empresa/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
