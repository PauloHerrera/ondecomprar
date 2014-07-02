using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeComprar.Model
{
    public class Empresa
    {
        public Int64 EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Descritivo { get; set; }
        public string TextoDestaque { get; set; }
        public string Site { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Logotipo { get; set; }
        
        public string EmailUsuario { get; set; }
        public string EmailEmpresa { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Password { get; set; }
       
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }

        public string HorarioFuncionamento { get; set; }

        //Dados do endereço na mesma tabela, pois é fator chave na busca
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string PontoDeReferencia { get; set; }
        public bool Ativo { get; set; }

        public bool CadastroAtivado { get; set; }

        //Palavras Chave na mesma tabela, pois também é fator chave na busca
        public string PalavrasChave { get; set; }

        public List<EmpresaImagem> EmpresaImagem { get; set; }

        //TIPO DE VENDA: ATACADO - VAREJO ?
        //FORMAS DE PAGAMENTO
        //DETALHES ESPECIAIS: 
    }
}
