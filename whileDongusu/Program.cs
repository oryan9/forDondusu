



//string name = "";

//while (string.IsNullOrEmpty(name))
//{
//    Console.WriteLine($"İsminiz:");
//    name =  Console.ReadLine();
//    //break;
//}
//Console.WriteLine($" Merhaba {name}");


string name = "";
do
{
    Console.WriteLine($"isminiz; {name}");
    name = Console.ReadLine();
    break;
} while (string.IsNullOrEmpty(name));

Console.WriteLine($"Heyy: {name} ");