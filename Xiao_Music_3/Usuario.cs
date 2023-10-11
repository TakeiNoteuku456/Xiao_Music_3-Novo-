using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiao_Music_3
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _senha;

        public Usuario(string nome,
            string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public Usuario(int id,
            string nome,
            string senha)
        {
            Nome = nome;
            Senha = senha;
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
        public string Senha
        {
            set { _senha = value; }
            get { return _senha; }
        }
    }
}
