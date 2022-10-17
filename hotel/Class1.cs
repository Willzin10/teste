
namespace Hotel
{
    public class Quarto
    {
        string[] quartos = new string[10];
        public void EscolhaEntrada()
        {
            Console.WriteLine("Escolha um quarto de 1 - 10");
            int escolha2 = Convert.ToInt32(Console.ReadLine());

            if (escolha2 == 1)
            {
                if (quartos[0] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[0] = "ocupado";
                }

            }
            if (escolha2 == 2)
            {
                if (quartos[1] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[1] = "ocupado";
                }

            }
            if (escolha2 == 3)
            {
                if (quartos[2] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[2] = "ocupado";
                }

            }
            if (escolha2 == 4)
            {
                if (quartos[3] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[3] = "ocupado";
                }

            }
            if (escolha2 == 5)
            {
                if (quartos[4] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[4] = "ocupado";
                }

            }
            if (escolha2 == 6)
            {
                if (quartos[5] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[5] = "ocupado";
                }

            }
            if (escolha2 == 7)
            {
                if (quartos[6] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[6] = "ocupado";
                }

            }
            if (escolha2 == 8)
            {
                if (quartos[7] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[7] = "ocupado";
                }

            }
            if (escolha2 == 9)
            {
                if (quartos[8] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[8] = "ocupado";
                }

            }
            if (escolha2 == 10)
            {
                if (quartos[9] == "ocupado")
                {
                    Console.WriteLine("Esse quarto está ocupado\n");
                }
                else
                {
                    Console.WriteLine("seu check-in foi feito\n");
                    quartos[9] = "ocupado";
                }

            }

        }
        public void EscolhaSaida()
        {
            Console.WriteLine("Escolha um quarto de 1-10 para fazer check-out");
            int escolha3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (escolha3 == 1)
            {
                if (quartos[0] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[0] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 2)
            {
                if (quartos[1] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[1] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 3)
            {
                if (quartos[2] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[2] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 4)
            {
                if (quartos[3] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[3] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 5)
            {
                if (quartos[4] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[4] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 6)
            {
                if (quartos[5] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[5] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 7)
            {
                if (quartos[6] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[6] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 8)
            {
                if (quartos[7] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[7] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 9)
            {
                if (quartos[8] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[8] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }
            if (escolha3 == 10)
            {
                if (quartos[9] == "ocupado")
                {
                    Console.WriteLine("O quarto está livre agora\n");
                    quartos[9] = "";
                }
                else
                {
                    Console.WriteLine("O quarto não estava ocupado\n");
                }
            }

        }
    }
    
}
