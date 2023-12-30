Console.WriteLine("\n Adionando a lista \n");

var lista = new List<string>()
{
    "Paulo","Maria","Bia","Pedro","Marcos"
};

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1} . {lista[i]}");

}
Console.WriteLine("\n Adionando a lista indice Mendes[5] e Marta por ultimo\n");
lista.Insert(5, "Mendes");
lista.Add("Marta");
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1} . {lista[i]}");
}



Console.WriteLine("\nAdionando a lista array Dina,Leandro e Carlos a partir [6]\n");
string[] array1 = { "Dina", "Leandro", "Carlos" };
lista.InsertRange(6, array1);
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1} . {lista[i]}");
}



Console.WriteLine("\n Verificando elemento(CONTAINS) da lista 0 e 1\n");
var primeiro = lista[0];
var segundo = lista[1];
Console.WriteLine(primeiro);
Console.WriteLine(segundo);
Console.WriteLine(lista.Contains("Paulo"));
Console.WriteLine(lista.Contains("maria"));



Console.WriteLine("\n Alterando a lista indice 0 = Paulo e 1 = Maria \n");
lista[0] = "Zé";
lista[1] = "Ana";
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1} . {lista[i]}");
}



Console.WriteLine("\n Removendo a lista indice [1,1] Ana\n");
lista.Remove("Carlos");
lista.RemoveRange(1, 1);
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{i + 1} . {lista[i]}");
}


Console.WriteLine("\n Exibir lista função void ExibirLista usando Foreach\n");

ExibirLista(lista);

Console.WriteLine("\n Ordena lista usando Short \n");
lista.Sort();
ExibirLista(lista);
Console.WriteLine("\n Limpando a Lista Clear \n");
lista.Clear();
ExibirLista(lista);
Console.WriteLine(lista.Count + " itens");
Console.WriteLine("\nFim\n");



var lista2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

lista2.Remove(7);
lista2.RemoveAt(4);
lista2.RemoveRange(0, 1);



Console.WriteLine(lista.Count + " itens \n ");
Console.WriteLine(lista2.Count + " itens \n");


Console.ReadLine();

static void ExibirLista(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}