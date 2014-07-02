using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using OndeComprar.Model;

namespace OndeComprar.MVC.Models
{
    public class EmpresaViewModel
    {
        public Int64 EmpresaId { get; set; }

        [DisplayName("Nome da Empresa:")]
        public string Nome { get; set; }

        [DisplayName("CNPJ:")]
        public string Cnpj { get; set; }
        public string Descritivo { get; set; }

        [DisplayName("Texto de Destaque:")]
        public string TextoDestaque { get; set; }
        public string Site { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }

        [DisplayName("Email:")]
        public string EmailUsuario { get; set; }

        [DisplayName("Email da Empresa:")]
        public string EmailEmpresa { get; set; }

        [DisplayName("Nome do Usuário:")]
        public string NomeDeUsuario { get; set; }

        [DisplayName("Senha:")]
        public string Password { get; set; }
       
        public string Logotipo { get; set; }

        //Dados do endereço na mesma tabela, pois é fator chave na busca
        [DisplayName("Endereço:")]
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string PontoDeReferencia { get; set; }
        public string Telefone { get; set; }

        //Palavras Chave na mesma tabela, pois também é fator chave na busca
        public string PalavrasChave { get; set; }

        public static EmpresaViewModel EmpresaEntityToViewModel(Empresa empresa)
        {
            if (empresa == null)
                return new EmpresaViewModel();

            var empresaVm = new EmpresaViewModel()
                                {
                                    EmpresaId = empresa.EmpresaId,
                                    Nome = empresa.Nome,
                                    NomeDeUsuario = empresa.NomeDeUsuario,
                                    Password = empresa.Password,
                                    Logotipo = empresa.Logotipo,
                                    Logradouro = empresa.Logradouro,
                                    Site = empresa.Site,
                                    Facebook = empresa.Facebook,
                                    Descritivo = empresa.Descritivo,
                                    TextoDestaque = empresa.TextoDestaque,
                                    Cidade = empresa.Cidade,
                                    Complemento = empresa.Complemento,
                                    Estado = empresa.Estado,
                                    PontoDeReferencia = empresa.PontoDeReferencia,
                                    Telefone = empresa.Telefone1,
                                    EmailEmpresa = empresa.EmailEmpresa,
                                    EmailUsuario = empresa.EmailUsuario,
                                    Twitter = empresa.Twitter,
                                    Bairro = empresa.Bairro,
                                    Cnpj = empresa.Cnpj
                                };

            return empresaVm;

        }

        public static Empresa EmpresaViewModelToEntity(EmpresaViewModel empresa)
        {
            if (empresa == null)
                return new Empresa();

            var empresaVm = new Empresa()
            {
                EmpresaId = empresa.EmpresaId,
                Nome = empresa.Nome,
                NomeDeUsuario = empresa.NomeDeUsuario,
                Password = empresa.Password,
                Logotipo = empresa.Logotipo,
                Logradouro = empresa.Logradouro,
                Site = empresa.Site,
                Facebook = empresa.Facebook,
                Descritivo = empresa.Descritivo,
                TextoDestaque = empresa.TextoDestaque,
                Cidade = empresa.Cidade,
                Complemento = empresa.Complemento,
                Estado = empresa.Estado,
                PontoDeReferencia = empresa.PontoDeReferencia,
                Telefone1 = empresa.Telefone,
                EmailEmpresa = empresa.EmailEmpresa,
                EmailUsuario = empresa.EmailUsuario,
                Twitter = empresa.Twitter,
                Bairro = empresa.Bairro,
                Cnpj = empresa.Cnpj
            };

            return empresaVm;

        }
    }
}
