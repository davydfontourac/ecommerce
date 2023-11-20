using MySqlX.XDevAPI;
using System;

namespace WebApplication_C.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }
        public string EnderecoRua { get; set; }
        public int EnderecoNumero { get; set; }
        public string EnderecoComplemento { get; set; }
        public long CEP { get; set; }
        public long Telefone { get; set; }
        public Boolean Admin { get; set; }

        public Usuario(long CPF, string Nome, string Sobrenome, string Senha, string Email, string Genero, string EnderecoRua, int EnderecoNumero, string EnderecoComplemento, long CEP, long Telefone, Boolean Admin)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Senha = Senha;
            this.Email = Email;
            this.Genero = Genero;
            this.EnderecoRua = EnderecoRua;
            this.Telefone = Telefone;
            this.Admin = Admin;
            this.CEP = CEP;
            this.EnderecoNumero = EnderecoNumero;
            this.EnderecoComplemento = EnderecoComplemento;
        }

        public Usuario(long CPF, string Senha)
        {
            this.CPF = CPF;
            this.Senha = Senha;
            this.Email = "";
            this.Nome = "";
            this.Sobrenome = "";
            this.Genero = "";
            this.EnderecoRua = "";
            this.Telefone = 0;
            this.Admin = false;
            this.CEP = 0;
            this.EnderecoNumero = 0;
            this.EnderecoComplemento = "";
        }

        public Usuario()
        {
            this.CPF = 0;
            this.Nome = "";
            this.Sobrenome = "";
            this.Senha = "";
            this.Email = "";
            this.Genero = "";
            this.EnderecoRua = "";
            this.Telefone = 0;
            this.Admin = false;
            this.CEP = 0;
            this.EnderecoNumero = 0;
            this.EnderecoComplemento = "";
        }
    }
}
