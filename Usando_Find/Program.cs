List<string> frutas = new()
{
    "Uva","Banana","Pera","Maça","Abacate","Laranja","Morango"

};

var fruta1 = frutas.Find(Procura);
Console.WriteLine(fruta1);
static bool Procura(string item)
{
    return item.Contains('n');
}

var fruta2 = frutas.Find(Procura1);

Console.WriteLine(fruta2);
static bool Procura1(string item)
{
    return item.StartsWith('L');

}

Console.ReadLine();