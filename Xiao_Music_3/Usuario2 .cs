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
        private int _id;
        private string _nome;
        private string _sobrenome;
        private string _cpf;

        public Usuario2(string nome,
            string sobrenome,
            string cpf )
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
        }
        public Usuario2(int id,
            string nome,
            string sobrenome,
            string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Id = id;
        }
        public int Id
        {
             set { _id = value; }
             get { return _id; }
        }
        public string Nome
        {
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio");
                _nome = value;
            }
            get { return _nome;  }
        }
        public string Sobrenome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio");
                _sobrenome = value;
            }
            get { return _sobrenome; }
        }
        public string Cpf
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio");
                _cpf = value;
            }
            get { return _cpf; }
        }
    }
}
