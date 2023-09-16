using System;

class Aluno
{
    public string Nome { get; set; }
    public int RA { get; set; }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"RA: {RA}");
    }
}

class AlunoGraduacao : Aluno
{
    public string Curso { get; set; }

    public void MostrarInformacoesGraduacao()
    {
        MostrarInformacoes();
        Console.WriteLine($"Curso: {Curso}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AlunoGraduacao aluno1 = new AlunoGraduacao
        {
            Nome = "Victor",
            RA = N0143B5,
            Curso = "ADS"
        };

        Aluno aluno2 = new Aluno
        {
            Nome = "Matheus",
            RA = 67890
        };

        Console.WriteLine("Informações do Aluno de Graduação:");
        aluno1.MostrarInformacoesGraduacao();

        Console.WriteLine("\nInformações do Aluno:");
        aluno2.MostrarInformacoes();
    }
//Nessa aplicação a classe Aluno possui dois tipos de atributos (NOME e RA) e um método (MostrarInformacao) que mostra as informações do aluno. A classe derivada seria AlunoGraduacao,
//onde tem mais um atributo (Curso) e mais um metodo que seria MostrarInformacaoGraduacao(), onde mostra as informações de aluno e subsequente as de alunograduacao.
}
