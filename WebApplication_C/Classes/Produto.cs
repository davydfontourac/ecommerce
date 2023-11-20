using MySqlX.XDevAPI;
using System;
using System.Runtime.InteropServices;

namespace WebApplication_C.Classes
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public int Categoria { get; set; }
        public string Descrição { get; set; }
        public string Imagem { get; set; }
        public float Valor { get; set; }
        public float Peso { get; set; }
        public float DimensaoLargura { get; set; }
        public float DimensaoAltura { get; set; }
        public float DimensaoProfundidade { get; set; }

        public Produto(string Nome, int Quantidade, int Categoria, string Descricao, string Imagem, float Valor, float Peso, float DimensaoLargura, float DimensaoAltura, float DimensaoProfundidade)
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
            this.Descrição = Descricao;
            this.Imagem = Imagem;
            this.Valor = Valor;
            this.Peso = Peso;
            this.DimensaoAltura = DimensaoAltura;
            this.DimensaoLargura = DimensaoLargura;
            this.DimensaoProfundidade = DimensaoProfundidade;
        }

        public Produto(string Nome, int Quantidade, int Categoria, float Valor)
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Categoria = Categoria;
            this.Descrição = "";
            this.Imagem = "";
            this.Valor = Valor;
            this.Peso = 0;
            this.DimensaoAltura = 0;
            this.DimensaoLargura = 0;
            this.DimensaoProfundidade = 0;
        }

        public Produto()
        {
            this.Nome = "";
            this.Quantidade = 0;
            this.Categoria = 0;
            this.Descrição = "";
            this.Imagem = "";
            this.Valor = 0;
            this.Peso = 0;
            this.DimensaoAltura = 0;
            this.DimensaoLargura = 0;
            this.DimensaoProfundidade = 0;
        }
    }
}
