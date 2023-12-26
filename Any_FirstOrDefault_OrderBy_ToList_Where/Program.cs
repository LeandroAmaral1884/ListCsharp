var limiteCredito = new List<Limite>();

Console.WriteLine("Com método SEM TOLIST evita de ser chamado mais de uma vez a lista,tirando .ToList() se ve a diferença\n");
for (int i = 1; i < 16; i++)
{
    limiteCredito.Add(new Limite() { Numero=i });
}

var limiteComRestricao=limiteCredito.Where(x => x.AnalisaLimite()).ToList();


if (limiteComRestricao.Count() > 3)
{
    Console.WriteLine("\n## Temos mais de 3 limites com restrição ");
}

if (limiteComRestricao.Count() > 5)
{
    Console.WriteLine("\n## Temos mais de 5 limites com restrição ");
}

var primeiroLimiteComRestrcao = limiteComRestricao.FirstOrDefault();
Console.WriteLine($"\n## {primeiroLimiteComRestrcao}");


Console.WriteLine("\n\nFim do Processamento...");
Console.ReadLine();
public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;

    public Limite()
    {
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random().Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de Crédito para o limte {Numero}");
        return isRestricao;
    }


}