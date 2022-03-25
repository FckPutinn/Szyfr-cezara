// See https://aka.ms/new-console-template for more information
int klucz;
Console.WriteLine("Podaj klucz szyfru:");
klucz = Int32.Parse(Console.ReadLine());
Console.WriteLine("Podaj fraze do zaszyfrowania:");
foreach (var fraza in Console.ReadLine())
{
    Console.Write(Convert.ToChar((fraza - 'a' + klucz) % ('z' - 'a' + klucz) + 'a'));
}