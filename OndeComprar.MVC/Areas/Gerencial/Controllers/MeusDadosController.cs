using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using OndeComprar.MVC.Areas.Gerencial.Models;
using OndeComprar.MVC.Models;
using OndeComprar.Model;
using OndeComprar.Model.Interfaces;

namespace OndeComprar.MVC.Areas.Gerencial.Controllers
{
    public class MeusDadosController : Controller
    {
        private IRepositorioGenerico<Empresa> _repositorio;

        [Inject]
        public MeusDadosController(IRepositorioGenerico<Empresa> repositorio)
        {
            _repositorio = repositorio;
        }

        //
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DadosUsuario()
        {
            var empresa = EmpresaViewModel.EmpresaEntityToViewModel(_repositorio.Get(1));
         
            return View(empresa);
        }

        [HttpPost]
        public ActionResult DadosUsuario(EmpresaViewModel empresaVm)
        {

            var empresa = _repositorio.Get(empresaVm.EmpresaId);

            empresa.NomeDeUsuario = empresaVm.NomeDeUsuario;
            empresa.Email = empresaVm.Email;
            empresa.Password = empresaVm.Password;

            _repositorio.Update(empresa);

            return View(empresaVm);
        }

        public ActionResult DadosEmpresa()
        {
            return View();
        }

        public ActionResult Descricao()
        {
            return View();
        }

        public ActionResult Imagens(long id )
        {
            var viewModel = new List<ImagemViewModel>();

            //var path = AppDomain.CurrentDomain.BaseDirectory;

            //Cria o caminho
            var path = @"\public\uploads\myimages\" + id.ToString() + @"\";


            //Marca o diretório a ser listado
            DirectoryInfo diretorio = new DirectoryInfo( Server.MapPath(path));
            
            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                viewModel.Add(new ImagemViewModel()
                                  {
                                      Nome = fileinfo.Name,
                                      CompletePath = Request.ApplicationPath + path + fileinfo.Name
                                  });
            }

            return View(viewModel);
        }
        
        [HttpPost]
        public string SalvaImagem(HttpPostedFileBase file, long id)
        {
            var teste = file;

            var path = AppDomain.CurrentDomain.BaseDirectory;

            //Cria o caminho
            path = path + @"\public\uploads\myimages\" + id.ToString();

            var teste2 = Server.MapPath(@"\public\uploads\myimages\");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var extension = Path.GetExtension(file.FileName);

            path = path + @"\" + Guid.NewGuid() + extension;

            file.SaveAs(path);

            return "Ok";
        }

        public ActionResult DeletarImagem(string nome, string id)
        {
            var caminho = Server.MapPath(@"\public\uploads\myimages\" + id + @"\") + nome;

            if (System.IO.File.Exists(caminho))
                System.IO.File.Delete(caminho);

            var viewModel = new List<ImagemViewModel>();

            //var path = AppDomain.CurrentDomain.BaseDirectory;

            //Cria o caminho
            var path = @"\public\uploads\myimages\" + id + @"\";


            //Marca o diretório a ser listado
            DirectoryInfo diretorio = new DirectoryInfo(Server.MapPath(path));

            FileInfo[] Arquivos = diretorio.GetFiles("*.*");

            //Começamos a listar os arquivos
            foreach (FileInfo fileinfo in Arquivos)
            {
                viewModel.Add(new ImagemViewModel()
                {
                    Nome = fileinfo.Name,
                    CompletePath = Request.ApplicationPath + path + fileinfo.Name
                });
            }

            return PartialView("_ListaImagens", viewModel);

        }

        public ActionResult Estatisticas()
        {
            return View();
        }

    }
}
