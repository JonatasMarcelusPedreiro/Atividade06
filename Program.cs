using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int data;
            int dia;
            string periodo;

            Console.WriteLine(" Olá, espero que você esteja bem, nós somos AIRPLANE um programa" +
                "de vendas de passagens áreas. \n");

            Console.WriteLine(" Para começar escolha uma dos meses abaixo para compra da passagem");
            Console.WriteLine(" 08 \n 09 \n 10 ");

            data= Int32.Parse(Console.ReadLine());
            Console.WriteLine($" {data} ");

            if (data == 08) if (data == 09) if (data==10) 
                    
                    
                    {
                        Console.WriteLine(" Ok, agora escolha os dias disponíveis para a viagem entre 6 e 21:");
                    
                    }
                    else
                    {

                        Console.WriteLine(" Mês inválido");
                        return;
                    }


            
            dia = Int32.Parse(Console.ReadLine());
            if (dia >= 6) if ( dia == 21) 
            {
                    Console.WriteLine(" Ok,Em qual período você deseja viajar : \n Manhã \n Tarde \n Noite");



            } else
                {

                    Console.WriteLine(" Dia inválido");
                    return;
                }
            periodo = (Console.ReadLine());
            Console.WriteLine(" Maravilha! A passagem foi comprada com sucesso");
            Console.WriteLine($" Você irá viajar no dia {dia}/{data} no período da {periodo} ");

            Console.ReadKey();

        } 


    }
}
