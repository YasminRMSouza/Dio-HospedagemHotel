using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel_c_.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        public string Nome 
        { 
            get => _nome;
            
            set
            {
                if (value == "" | value == " ")
                {
                    throw new ArgumentException("O nome não pode estar em branco");
                }
                _nome = value;
            } 
        }

        public string Sobrenome 
        { 
            get => _sobrenome; 
            
            set
            {
                if (value == "" | value ==" ")
                {
                    throw new ArgumentException("O Sobrenome não pode estar em branco");
                }
            } 
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}