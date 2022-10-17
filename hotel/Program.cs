using Hotel;
bool loop = true;
Quarto hotel = new Quarto();

while (loop == true)
{
    Console.WriteLine("1 - Fazer Check-in");
    Console.WriteLine("2 - Fazer Check-out");
    Console.WriteLine("3 - Sair");

    Console.WriteLine("O que você quer fazer?");
    int escolha = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (escolha == 1)
    {
        hotel.EscolhaEntrada();
    }
    if (escolha == 2)
    {
        hotel.EscolhaSaida();
    }
    if (escolha == 3)
    {
        loop = false;
    }
}