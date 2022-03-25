using System;
using ConsoleApp12.Entidades;
using ConsoleApp12.Entidades.Enums;
namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            PedidoOrder pedido = new PedidoOrder
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };
            Console.WriteLine(pedido);

            string txt = OrderStatus.PagamentoPendente.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");
            Console.WriteLine(os);
        }
    }
}
