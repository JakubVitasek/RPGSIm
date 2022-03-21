Dictionary <string,int> atributy = new Dictionary<string,int>();
atributy.Add("Síla", 10);
atributy.Add("Obrana", 10);
atributy.Add("Inteligence", 10);

Console.WriteLine("Jak chcete pojmenovat svůj charakter?");
string jmenoPostavy = Console.ReadLine();

Console.Clear();

string[] poleAtr = { "Síla", "Obrana", "Inteligence" };

int Spanek = 0;

int Level = 0;

while(true)
{
    Console.WriteLine($"{jmenoPostavy} je unavený na {Spanek}%");
    Console.WriteLine($"Chce se {jmenoPostavy}  vyspat nebo vyrazit na Quest? Q/V");
    string input = Console.ReadLine();
    Random ran = new Random();
    int cislo = ran.Next(0, 3);
    Console.Clear();

    if (input == "Q")
    {
        string vygAtr = poleAtr[cislo];
        Console.WriteLine($"{jmenoPostavy} se vydává se  quest {vygAtr}, vratí se za 10 sec");
        Console.WriteLine(". . .");
        Thread.Sleep(1000);
        Console.WriteLine($"{jmenoPostavy} se z výpravy vrátil živ a zdráv");
        Console.WriteLine(". . .");
        Spanek = Spanek + 10;
        atributy[vygAtr]  +=10;
        Level = Level + 1;
        Console.WriteLine($"{jmenoPostavy} má Level {Level}");
        foreach (var radekSlovniku in atributy)
        {
            Console.WriteLine($"Skill : {radekSlovniku.Key}, Level : {radekSlovniku.Value}");
        }
        Console.WriteLine(". . .");
    }

    if(input == "V")
    {
        Console.WriteLine($"{jmenoPostavy} spinká");
        Console.WriteLine(". . .");
        Thread.Sleep(10000);
        Spanek = 0;
        foreach (var radekSlovniku in atributy)
        {
            Console.WriteLine($"Skill : {radekSlovniku.Key}, Level : {radekSlovniku.Value}");
        }
        Console.WriteLine(". . .");
    }
     
}


