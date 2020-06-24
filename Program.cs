using System;

namespace Aula24ObjComoArg
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1 , "Jordan 1 x Off white", 3500.99f);
            Produto p2 = new Produto(2 , "Jordan 5 top 3", 900.99f);
            Produto p3 = new Produto(3 , "Nike dunk x ben & jerry", 7530.99f);
            Produto p4 = new Produto(4 , "Jordan 4 x kaws", 5000.00f);
            Produto p5 = new Produto(5 , "Blazer mid x off white ", 2500.99f);

            // Adicinar ao carrinho
            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);
            cart.AdicionarProduto(p5);

            //remover do carrinho
            cart.RemoverProduto(p2);

            cart.MostrarProdutos();

            cart.CalcularTotalDaCompra();





        }
    }
}
