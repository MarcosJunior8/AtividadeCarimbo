using System;

namespace atividade_3_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Interacao Caneta = new Caneta("a");
            Interacao Carimbo = new Carimbo("a");
            int menu;
            do
            {
                Console.WriteLine("1- Caneta \n2-Carimbo\n3-Sair");
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    int menucaneta;
                    do
                    {
                        Console.WriteLine("1-carregar\n2-usar \n3-trocar cor\n4-trocar texto\n5-voltar");                      
                        menucaneta = Convert.ToInt32(Console.ReadLine());

                        if (menucaneta == 1)
                        {
                            Console.WriteLine("\nEscolha a cor e a carga que deseja: \n");
                           
                            Caneta.carregar(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                        }

                        if (menucaneta == 2)
                        {
                            Caneta.usar();
                         
                        }
                        
                        if(menucaneta == 3) {
                            Caneta.trocarCor(Console.ReadLine());
                        }

                        if (menucaneta == 4)
                        {
                            Caneta.trocarTexto(Console.ReadLine());
                        }


                    } while (menucaneta != 5);
                }


                if (menu == 2)
                {
                    int menucarimbo;
                    do
                    {
                        Console.WriteLine("1-carregar\n2-usar \n3-trocar cor\n4-trocar texto\n5-voltar");
                        menucarimbo = Convert.ToInt32(Console.ReadLine());

                        if (menucarimbo == 1)
                        {
                            Console.WriteLine("\nEscolha a cor e a carga que deseja: \n");

                            Carimbo.carregar(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                        }

                        if (menucarimbo == 2)
                        {
                            Carimbo.usar();

                        }

                        if (menucarimbo == 3)
                        {
                            Carimbo.trocarCor(Console.ReadLine());
                        }

                        if (menucarimbo == 4)
                        {
                            Carimbo.trocarTexto(Console.ReadLine());
                        }


                    } while (menucarimbo != 5);
                }

            }while(menu != 3);
        }
    }
}
