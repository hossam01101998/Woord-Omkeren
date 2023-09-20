Console.WriteLine("****************************************");
Console.WriteLine("Omkeren");
Console.WriteLine("****************************************");
Console.WriteLine();
Console.WriteLine("Schrijf maar iets");

string word = Console.ReadLine();

Console.WriteLine("Kies een methode:");
Console.WriteLine("1. For loop");
Console.WriteLine("2. While loop");
Console.WriteLine("3. Do-While loop");
Console.WriteLine("4. Recursie");

char keuze = Console.ReadLine().First();

Console.WriteLine(word);
Console.WriteLine(keuze);



Console.WriteLine();
Console.WriteLine("Jouw woord is: " + word);

string result = "";
int i = 0;

switch (keuze) {

    case '1':


        for (i = word.Length-1; i >= 0; i--)
        {
             result += word[i];

        }

        break;


    case '2':

        i = word.Length - 1;

        while (i >= 0)
        {
            result += word[i];
            i--;
        }

        break;

    case '3':
        i = word.Length - 1;
        do
        {
            
            result += word[i];
            i--;
        } 
        while (i >= 0);

        break;

    case '4':

        result = Omkerenwoord(word);

        break;

    default:
        Console.WriteLine("Geen bestaande optie");
        break;

}
Console.WriteLine("Het omgekeerd woord is: " + result);

static string Omkerenwoord (string word)
{
    if (word.Length <= 1) {
        return word;
    }
    else {
       /* i = word.Length - 1;

        result += word[i];
        i--; */
       char firstChar  = word[0];
        string restOfWord = word.Substring(1);

        return Omkerenwoord(restOfWord) + firstChar;
            }
}