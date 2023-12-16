
var lista = new List<string>()
{
    "Paulo","Maria","Bia","Pedro","Marcos"
};

lista.Add("Marta");

lista.Insert(1, "Bia");

Console.WriteLine(lista.Count + " itens");


Console.ReadLine();