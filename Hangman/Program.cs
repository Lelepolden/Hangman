/*
Bestämma ord
Visa ett _ för varje bokstav i ordet
Ta in en gissning
Om gissningen finns i ordet
    Skriver på rätt plats (motsvarande bokstavens plats i ordet)
annars
    Lägger till bokstaven till de felaktiga gissningarna
    Ritar ett steg till av gubben
Fortsätt tills gubben dör eller ordet gissas rätt.w
*/

string word = "Volvo";

char guess = Console.ReadLine()[0];
/* 
bool inWord = false;
for (int i = 0; i < word.Length; i++)
{
    if (word[i] == guess)
    {
        inWord = true;
    }
}
*/
bool inWord = word.Contains(guess);

if (inWord == true)
{
    Console.WriteLine("yay");
}

Console.ReadLine();
