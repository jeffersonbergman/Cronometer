
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();//ToLower converte tudo para minusculo.
    char type = char.Parse(data.Substring(data.Length-1, 1));
    int time = int.Parse(data.Substring(0, data.Length -1));
    int multiplier = 1;

    if(type == 'm')
    {
        multiplier = 60;
    }
    if(time == 0)
    {
        System.Environment.Exit(0);
    }

    PreStart(time * multiplier);
    //char  = character, char.Parse(Conversão)
    //Substring(1,1) 1 = a posição do caracter que eu quero, 1 = o número de caracter. 
    //Substring(data.Length-1, 1) o data é a variável que vou receber, o length vai contar a quantidade de character e o -1 vai ser sempre a quantidade total -1 que é o ultimo.
    //Substring(0, data.Length -1) vai me retornar todos os caracters a partir do 0 e o -1 vai remover só o ultimo que no caso vai ser o S de Segundos.
}


static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Read...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...!");
    Thread.Sleep(2500);
    Start(time);
}
static void Start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        //limpar a tela 
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        //Thread.Sleep vai fazer o meu programa esperar 1000milesegundos para executar novamente o laço.
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Stopwatch finalizado.");
    Thread.Sleep(2500);
    Menu();
    
}