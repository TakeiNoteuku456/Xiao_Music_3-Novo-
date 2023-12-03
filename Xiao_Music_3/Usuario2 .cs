using iTextSharp.text.pdf.codec.wmf;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiao_Music_3
{
    public class Usuario2
    {
        //cria variaveis
        private int _id;
        private string _nome;
        private string _sobrenome;
        private string _cpf;
        public Usuario2
            //Esta linha declara um método público chamado Usuario2
            //Um construtor é um método especial que é chamado quando uma instância da classe é criada.
            (string nome,
            string sobrenome,
            string cpf )
        //Este construtor aceita três parâmetros e inicializa as propriedades correspondentes da classe com esses valores.
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;//Estas linhas atribuem os valores passados como parâmetros aos campos correspondentes da instância da classe.
        }
        public Usuario2 //Este construtor aceita um parâmetro adicional(id) em comparação com o primeiro construtor.
            (int id,
            string nome,
            string sobrenome,
            string cpf)//Este construtor aceita um parâmetro adicional (id) em comparação com o primeiro construtor. 
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Id = id;
        }//Estas linhas fazem a mesma coisa que no primeiro construtor, mas também atribuem o valor do parâmetro id à propriedade Id.
        public int Id//Esta linha declara uma propriedade pública.
        {
             set { _id = value; }//para definir o valor do campo "_id".
            get { return _id; }//para obter o valor do campo "_id".
        }
        public string Nome//Esta linha declara uma propriedade pública.
        {
            set {
                //Estas linhas verificam se o valor passado para a propriedade (value) é nulo ou uma string vazia.
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException //indicando que o campo não pode ser vazio.
                        ("Campo Nome está vazio");
                _nome = value;//Esta linha atribui o valor válido à variável de instância _nome após a verificação
            }
            get { return _nome; }//retorna o valor da variável.
        }
        public string Sobrenome//Esta linha declara uma propriedade pública.
        {
            set
            {   
                //Estas linhas verificam se o valor passado para a propriedade (value) é nulo ou uma string vazia.
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException //indicando que o campo não pode ser vazio.
                        ("Campo Nome está vazio");
                _sobrenome = value;//Esta linha atribui o valor válido à variável de instância _nome após a verificação.
            }
            get { return _sobrenome; }//retorna o valor da variável.
        }
        public string Cpf//Esta linha declara uma propriedade pública.
        {
            set
            {
                //Estas linhas verificam se o valor passado para a propriedade (value) é nulo ou uma string vazia.
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException//indicando que o campo não pode ser vazio.
                        ("Campo Nome está vazio");
                _cpf = value;//Esta linha atribui o valor válido à variável de instância _nome após a verificação.
            }
            get { return _cpf; }//retorna o valor da variável.
        }
    }
}
