using MySqlX.XDevAPI;
using System;
using System.Runtime.InteropServices;

namespace WebApplication_C.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Categoria { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public float Valor { get; set; }
        public float Peso { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public float Profundidade { get; set; }

        public Produto(string Nome, int Quantidade, int Categoria, string Descricao, string Imagem, float Valor, float Peso, float Largura, float Altura, float Profundidade)
        {
            this.Id = 0;
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
            this.Descricao = Descricao;
            this.Imagem = Imagem;
            this.Valor = Valor;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Largura = Largura;
            this.Profundidade = Profundidade;
        }

        public Produto(int Id, string Nome, int Quantidade, int Categoria, string Descricao, string Imagem, float Valor, float Peso, float Largura, float Altura, float Profundidade)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
            this.Descricao = Descricao;
            this.Imagem = Imagem;
            this.Valor = Valor;
            this.Peso = Peso;
            this.Altura = Altura;
            this.Largura = Largura;
            this.Profundidade = Profundidade;
        }

        public Produto(string Nome, int Quantidade, int Categoria, float Valor)
        {
            this.Id = 0;
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
            this.Descricao = "";
            this.Imagem = "";
            this.Valor = Valor;
            this.Peso = 0;
            this.Altura = 0;
            this.Largura = 0;
            this.Profundidade = 0;
        }

        public Produto()
        {
            this.Id = 0;
            this.Nome = "";
            this.Quantidade = 0;
            this.Categoria = 0;
            this.Descricao = "";
            this.Imagem = "";
            this.Valor = 0;
            this.Peso = 0;
            this.Altura = 0;
            this.Largura = 0;
            this.Profundidade = 0;
        }
    }
}
