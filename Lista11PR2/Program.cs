using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_14_06
{
    internal class Program
    {
        static void Exercicio1()
        {
            Console.WriteLine("Aqui será codificado o exeercício 1");

            int tent;
            int[] num = new int[1000];

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                num[i] = rand.Next();
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Tente adivinhar um números do vetor: ");
                tent = int.Parse(Console.ReadLine());

                if (tent == num[i])
                {
                    Console.WriteLine("Paranbéns, o número" + tent + "está presente no vetor");
                    break;
                }
            }
            Console.ReadKey();

        }
        static void Exercicio2()
        {
            Console.WriteLine("Aqui será codificado o exercício 2");

            int tent, soma = 0;
            int[] num = new int[20000];

            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                num[i] = rand.Next(0, 20000);
            }

            Console.WriteLine("Tente adivinhar um número do vetor: ");
            tent = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {

                if (tent == num[i])
                {
                    soma += 1;
                }

            }

            Console.WriteLine("Quantas vezes seu número apareeu no vetor: " + soma);
            Console.ReadKey();
        }
        static void Exercicio3()
        {
            Console.WriteLine("Aqui será codificado o exercício 3");
        }
        static void Exercicio4()
        {
            Console.WriteLine("Aqui será codificado o exercício 4");

            int[] num = new int[5000];

            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                num[i] = rand.Next();
            }

            for (int i = 0; i < 5000; i++)
            {
                if (num[i] % i == 0 && num[i] % 1 == 0)
                {
                    Console.WriteLine(num[i] + "");
                }

                //if (num[i] % i + 1 == 0)
                //{
                //    break;
                //}
                //else if (num[i] % i == 0 && num[i] % 1 == 0)
                //{
                //    Console.WriteLine(num[i] + "");
                //}
            }
            Console.ReadKey();









        }
        static void Main(string[] args)
        {
            int op;

            do
            {


                Console.WriteLine("****MENU****");
                Console.WriteLine("0 = Para SAIR");
                Console.WriteLine("1 = Exercício 1");
                Console.WriteLine("2 = Exercício 2");
                Console.WriteLine("3 = Exercício 3");
                Console.WriteLine("4 = Exercício 4");


                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Thank You for Using My Sistem");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;

                    default:
                        Console.WriteLine("ERROR, Try Again");
                        break;
                }

            } while (op != 0);



        }
    }
}
