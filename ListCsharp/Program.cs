//declarar uma coleção do tipo List<T>

List<string> lista;
lista = new List<string>();

List<int> lista1 = new List<int>();
var lista2 = new List<float>();

List<double> lista3 = new List<double>();

List<string> nomes = new();

nomes.Add("Paulo");
nomes.Add("Maria");

var lista4 = new List<string>()
{
    "Paulo","Maria","Bia","Pedro","Marcos"
};

Console.ReadLine();