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

int cas = 10000;

int cas2 = cas / 1000;

while(true)
{
    Console.WriteLine($"{jmenoPostavy} je unavený na {Spanek}%");
    Console.WriteLine($"Chce se {jmenoPostavy}  vyspat nebo vyrazit na Quest? Q/V");
    string input = Console.ReadLine().ToLower();
    Random ran = new Random();
    int cislo = ran.Next(0, 3);
    Console.Clear();

    if (input == "q")
    {
        string vygAtr = poleAtr[cislo];
        Console.WriteLine($"{jmenoPostavy} se vydává se  quest {vygAtr}, vratí se za {cas2} sec");
        Console.WriteLine(". . . . . . . . .");
        Thread.Sleep(cas);
        Console.WriteLine($"{jmenoPostavy} se z výpravy vrátil živ a zdráv");
        Console.WriteLine(". . . . . . . . .");
        Spanek = Spanek + 10;
        atributy[vygAtr]  +=10;
        Level = Level + 1;
        cas = cas + 1000;
        Console.WriteLine($"{jmenoPostavy} má Level {Level}");
        Console.WriteLine(". . . . . . . . .");
        foreach (var radekSlovniku in atributy)
        {
            Console.WriteLine($"Skill : {radekSlovniku.Key}, Level : {radekSlovniku.Value}");
        }
        Console.WriteLine(". . . . . . . . .");
    }

    if(input == "v")
    {
        Console.WriteLine($"{jmenoPostavy} spinká <3");
        Console.WriteLine(". . . . . . . . .");
        Thread.Sleep(10000);
        Spanek = 0;
        Console.WriteLine($"{jmenoPostavy} je už zase plný energie");
        Console.WriteLine(". . . . . . . . .");
        foreach (var radekSlovniku in atributy)
        {
            Console.WriteLine($"Skill : {radekSlovniku.Key}, Level : {radekSlovniku.Value}");
        }
        Console.WriteLine(". . . . . . . . .");
    }
     
}


