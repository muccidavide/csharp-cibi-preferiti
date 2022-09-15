// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "pizza", "pasta", "lasagna", "cioccolato", "gelato", "hamburger"};

Console.WriteLine(cibiPreferiti.Length);

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine(cibiPreferiti[0]);

int posizioneUltimoCibo = cibiPreferiti.Length - 1;
Console.WriteLine(cibiPreferiti[posizioneUltimoCibo]);