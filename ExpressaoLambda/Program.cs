List<string> frutas = new()
{
    "0 = Uva","1 = Banana","2 = Pera","3 = Maça","4 = Laranja","5 = Abacate","6 = Morango"

};

frutas.Sort();
foreach (var frut in frutas)
{
    Console.WriteLine(frut);
}

// usando a espressão Lambda: pega primeira palavra com N
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nExpressão Lambda (=>) pega primeira palavra com N : {fruta2}");


//usando Predicado como funções Find: pega primeira palavra com N
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"\nExpressão Find pega primeira palavra com N (Predicado) : {fruta1}");

//usando Predicado como funções FindLast: pega primeira palavra com N
var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\nExpressão FindLast (Predicado) pega ultima palavra com N : {fruta3}\n\n\n");

//usando Predicado como funções FindLast: retorna primeiro indice com palavra com N
Console.WriteLine("\nExplicando FindIndex:");
Console.WriteLine("Explicando :var fruta4 = frutas.FindIndex(i => i.Contains('n'));\n var fruta4 armazena valor = frutas.FindIndex\n frutas.FindIndex recebe valor i\n i recebe valor => i.Contains\n indice = {fruta4} retorna valo = 1 (indice 1)\n {frutas[fruta4]} {frutas recebe [frutas4] retorna string do indice 1 = Banana}");
var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"Expressão FindIndex (Predicado) retorna primeiro indice com palavra com N : indice = {fruta4}  item = {frutas[fruta4]}\n" );

//usando Predicado como funções FindLastIndex: retorna ultimo indice com palavra com N
var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\nExpressão FindLastIndex (Predicado) retorna ultimo indice com palavra com N : indice = {fruta5}  item = {frutas[fruta5]}");

//usando Predicado como funções FindAll: retorna listas de palavra com N
var fruta6 = frutas.FindAll(i => i.Contains('n'));
Console.WriteLine($"\n\nExpressão FindAll (Predicado) retorna as palavra com N");
foreach (var item in fruta6)
{
    Console.WriteLine(item);
}

Console.ReadLine();

static bool Procura(string item)
{
   
    return item.Contains('n');
   
}