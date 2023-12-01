using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace WebApplication_C.Classes
{
    /// <summary>
    /// Classe com todos os métodos dos produtos do sistema
    /// </summary>
    public class Carrinho
    {
        public long Id_usuario { get; set; }
        public List<int> Id_produto { get; set; }

        /// <summary>
        /// Construtor completo do Carrinho
        /// </summary>
        /// <param name="Id_usuario"></param>
        /// <param name="Id_produto"></param>
        public Carrinho(long Id_usuario, List<int> Id_produto)
        {
            this.Id_usuario = Id_usuario;
            this.Id_produto = Id_produto;
        }

        /// <summary>
        /// Construtor do Carrinho
        /// </summary>
        public Carrinho()
        {
            this.Id_usuario = 0;
            this.Id_produto = new List<int>();
        }
    }
}
