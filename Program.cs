using AnaliseChamados;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var chamados = Dados.Carregar();

Relatorio.Resumo(chamados);
Relatorio.PorCategoria(chamados);
Relatorio.PorAgente(chamados);
Relatorio.ExportarCsv(chamados, "chamados.csv");
