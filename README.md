# Análise de Chamados (C#)

Aplicação de console em **C# / .NET** que analisa dados de atendimento ao cliente:
gera um resumo geral, estatísticas por categoria e por agente, e exporta os dados para CSV.

## O que demonstra
- Modelagem com `record`
- Consultas com **LINQ** (`GroupBy`, `Where`, `Average`, `OrderByDescending`)
- Formatação de números e porcentagens com `CultureInfo("pt-BR")`
- Leitura e escrita de arquivos (`File`, `StringBuilder`)

## Como rodar
Requer o [.NET SDK](https://dotnet.microsoft.com/download) 8 ou superior.

```bash
dotnet run
```

O arquivo `chamados.csv` é gerado na pasta de execução e pode ser aberto no Excel.

## Estrutura
```
Program.cs      # ponto de entrada
Chamado.cs      # modelo de dados
Dados.cs        # dados simulados
Relatorio.cs    # resumos e exportação CSV
```

## Ideias para evoluir
- Ler os chamados de um arquivo CSV ou JSON em vez de dados fixos
- Menu interativo para filtrar por categoria, status ou agente
- Salvar e consultar os dados em um banco SQL (SQLite com Entity Framework Core)
- Criar testes com xUnit

## Autor
Marcos André Sousa Cardoso — [LinkedIn](https://www.linkedin.com/in/marcsou777) · [GitHub](https://github.com/Marcos-Sousa-EXE)
