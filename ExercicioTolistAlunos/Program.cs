
List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);
Aluno Bia = new Aluno { Nome ="Bia", Nota = 7.75};
Aluno Mario = new Aluno { Nome ="Maria", Nota = 8.95};
alunos.Add(Bia);
alunos.Add(Mario);
ExibirAlunos(alunos);

var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

var ordenaLista=alunos.OrderBy(n=>n.Nome).ToList();
ExibirAlunos(ordenaLista);

var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior 8");
foreach (var item in alunosNotaOito)
{
    
    Console.WriteLine($"{item.Nome} = {item.Nota}");
}

Console.ReadLine();

static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome} = {item.Nota}");
        somaNotas += item.Nota;
    }
    var mediaNotas = somaNotas / alunos.Count();
    Console.WriteLine($"\nMédia das notas : {Math.Round(mediaNotas, 2)}\n");
    Console.WriteLine($"Total de alunos : {alunos.Count}");
}