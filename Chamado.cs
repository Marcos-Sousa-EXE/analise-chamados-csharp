namespace AnaliseChamados;

public record Chamado(
    int Id,
    string Categoria,
    string Agente,
    string Status,
    int TempoRespostaMin,
    int Nota);
