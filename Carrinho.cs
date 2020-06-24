using System;
using System.Collections.Generic;

namespace Aula24ObjComoArg
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        //metodo de adicionar
        List<Produto> carrinho = new List<Produto>();
        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }
        //Metodo de remover
        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }
        //listar os produtos no console
        public void MostrarProdutos()
        {
            foreach(Produto p in carrinho)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{p.Nome} - R${p.Preco.ToString("n2")}");
                Console.ResetColor();
            }
        }
        //Calcular o total da compra
        public void CalcularTotalDaCompra()
        {
            foreach (Produto p in carrinho)
            {
                ValorTotal += p.Preco;
            }
            System.Console.WriteLine($"Total do carrinho R${ValorTotal.ToString("n2")}");
        }

    }
}