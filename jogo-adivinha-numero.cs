Random aleatorio = new Random();
int numeroAleatorio = aleatorio.Next(1, 101);


do
{
    Console.Write("Digite seu palpite entre 1 e 100: ");
    int palpite = int.Parse(Console.ReadLine());

    if (palpite == numeroAleatorio)
    {
        Console.WriteLine("Você acertou, meu mano! ");
        break;
    }else if (palpite < numeroAleatorio) 
    {
        Console.WriteLine("Errou! Dica: É maior que isso...");
    }else if (palpite > numeroAleatorio)
    {
        Console.WriteLine("Errou! Dica: É menor que isso...");
    }
}   while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
