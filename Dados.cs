namespace AnaliseChamados;

// Dados simulados de atendimento ao cliente (os mesmos do dashboard em JavaScript).
public static class Dados
{
    public static List<Chamado> Carregar() =>
    [
        new(101, "Dúvida", "Ana Silva", "Fechado", 15, 5),
        new(102, "Problema Técnico", "Carlos Souza", "Fechado", 45, 4),
        new(103, "Financeiro", "Ana Silva", "Aberto", 120, 2),
        new(104, "Dúvida", "Beatriz Lima", "Fechado", 10, 5),
        new(105, "Problema Técnico", "Carlos Souza", "Pendente", 60, 3),
        new(106, "Elogio", "Beatriz Lima", "Fechado", 5, 5),
        new(107, "Financeiro", "Carlos Souza", "Fechado", 90, 4),
        new(108, "Problema Técnico", "Ana Silva", "Fechado", 30, 4),
        new(109, "Dúvida", "Beatriz Lima", "Fechado", 20, 5),
        new(110, "Problema Técnico", "Ana Silva", "Aberto", 50, 3),
        new(111, "Dúvida", "Carlos Souza", "Fechado", 12, 4),
        new(112, "Financeiro", "Beatriz Lima", "Pendente", 75, 3),
        new(113, "Problema Técnico", "Beatriz Lima", "Fechado", 38, 5),
        new(114, "Elogio", "Ana Silva", "Fechado", 8, 5),
        new(115, "Financeiro", "Ana Silva", "Fechado", 100, 3),
        new(116, "Dúvida", "Ana Silva", "Aberto", 25, 4),
        new(117, "Problema Técnico", "Carlos Souza", "Fechado", 55, 2),
        new(118, "Dúvida", "Beatriz Lima", "Fechado", 18, 5),
    ];
}
