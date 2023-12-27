


////// 1-Estânciando a Lista Aluno nomeando alunos e incluindo referencia da ListaDados e puxando metodo ListaAlunos(Método Estatico)
List<Aluno> alunos = ListasDados.ListaAlunos();
/////9- chama metodo ExibirAluno(incluindo seleção Aluno)
ExibirAlunos(alunos);
//10 - adiciona os alunos
Aluno Bia = new Aluno { Nome ="Bia", Nota = 7.75};
Aluno Mario = new Aluno { Nome ="Maria", Nota = 8.95};
alunos.Add(Bia);
alunos.Add(Mario);
ExibirAlunos(alunos);

/// 11 - procura o aluno usando Find usando Lambda N=>N.NOME para obter seleção e usando expressão n.Nome.Equals("Amanda")  para achar Amanda Equals
/// aluno1 para receber dados da Amanda depois de encontrar e depois remover
var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

///12-orderna a lista usando OrderBy usando Lambda N=>N.NOME para obter seleção e usando expressão n.Nome).ToList() conveter nova lista
var ordenaLista =alunos.OrderBy(n=>n.Nome).ToList();
//13- ExibirAluno recebe a lista(ordenaLista) e mostra a lista
ExibirAlunos(ordenaLista);

//14- Usando FindAll usando Lambda N=>N.NOME para obter seleção, usando expressão n.Nota >= 8) achar maior que 8
var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8);
Console.WriteLine("\nAlunos com nota maior 8");
//15- mostra seleção alunosNotaOito 
foreach (var item in alunosNotaOito)
{
    
    Console.WriteLine($"{item.Nome} = {item.Nota}");
}

Console.ReadLine();

///2- Cria metodo de exbição recebendo coleçao Lis<Aluno> alunos selecionando da linha 33 até 50 cria metodo extract metodo
static void ExibirAlunos(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de alunos");
    Console.WriteLine("\nNome\tNota");
    ///4- somar as notas
    var somaNotas = 0.0;

    ///3- mostra a coleção estânciando alunos para item
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome} = {item.Nota}");
        ///5-pega a nota e soma com anterior
        somaNotas += item.Nota;
    }
    ///6- nedia nota pega total da somaNotas e divide alunos.cont(cont conta quantos alunos tem na coleçao)
    var mediaNotas = somaNotas / alunos.Count();
    ///7- chamna recurso Math que possui Round para limitar as casas decimais em 2
    Console.WriteLine($"\nMédia das notas : {Math.Round(mediaNotas, 2)}\n");
    /// 8- alunos.count totaliza os alunos
    Console.WriteLine($"Total de alunos : {alunos.Count}");
}