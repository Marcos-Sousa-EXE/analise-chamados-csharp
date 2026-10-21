using System.Globalization;
using System.Text;

namespace AnaliseChamados;

public static class Relatorio
{
    private static readonly CultureInfo PtBr = new("pt-BR");

    public static void Resumo(List<Chamado> chamados)
    {
        double fechados = chamados.Count(c => c.Status == "Fechado");

        Console.WriteLine("=== RESUMO GERAL ===");
        Console.WriteLine($"Total de chamados:        {chamados.Count}");
        Console.WriteLine($"Tempo médio de resposta:  {chamados.Average(c => c.TempoRespostaMin).ToString("F1", PtBr)} min");
        Console.WriteLine($"Satisfação média:         {chamados.Average(c => c.Nota).ToString("F1", PtBr)}");
        Console.WriteLine($"Chamados fechados:        {(fechados / chamados.Count).ToString("P0", PtBr)}");
        Console.WriteLine();
    }

    public static void PorCategoria(List<Chamado> chamados)
    {
        Console.WriteLine("=== POR CATEGORIA ===");
        Console.WriteLine($"{"Categoria",-18}{"Qtd",5}{"Resposta (min)",16}{"Nota",8}");

        var grupos = chamados
            .GroupBy(c => c.Categoria)
            .Select(g => new
            {
                Categoria = g.Key,
                Qtd = g.Count(),
                Tempo = g.Average(c => c.TempoRespostaMin),
                Nota = g.Average(c => c.Nota)
            })
            .OrderByDescending(g => g.Qtd);

        foreach (var g in grupos)
        {
            Console.WriteLine($"{g.Categoria,-18}{g.Qtd,5}{g.Tempo.ToString("F1", PtBr),16}{g.Nota.ToString("F1", PtBr),8}");
        }
        Console.WriteLine();
    }

    public static void PorAgente(List<Chamado> chamados)
    {
        Console.WriteLine("=== POR AGENTE (somente chamados fechados) ===");
        Console.WriteLine($"{"Agente",-18}{"Qtd",5}{"Resposta (min)",16}{"Nota",8}");

        var grupos = chamados
            .Where(c => c.Status == "Fechado")
            .GroupBy(c => c.Agente)
            .Select(g => new
            {
                Agente = g.Key,
                Qtd = g.Count(),
                Tempo = g.Average(c => c.TempoRespostaMin),
                Nota = g.Average(c => c.Nota)
            })
            .OrderByDescending(g => g.Nota);

        foreach (var g in grupos)
        {
            Console.WriteLine($"{g.Agente,-18}{g.Qtd,5}{g.Tempo.ToString("F1", PtBr),16}{g.Nota.ToString("F1", PtBr),8}");
        }
        Console.WriteLine();
    }

    public static void ExportarCsv(List<Chamado> chamados, string caminho)
    {
        var sb = new StringBuilder();
        sb.AppendLine("id;categoria;agente;status;tempo_resposta_min;nota");

        foreach (var c in chamados)
        {
            sb.AppendLine($"{c.Id};{c.Categoria};{c.Agente};{c.Status};{c.TempoRespostaMin};{c.Nota}");
        }

        File.WriteAllText(caminho, sb.ToString(), Encoding.UTF8);
        Console.WriteLine($"Arquivo gerado: {Path.GetFullPath(caminho)}");
    }
}
