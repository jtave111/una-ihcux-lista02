// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("   SISTEMA EXPERT: MÃ³dulo de Boas-Vindas");
Console.WriteLine("========================================\n");

Console.Write("OlÃ¡, Recruta! Qual Ã© o seu nome de Desenvolvedor(a)? ");
string nome = Console.ReadLine();

Console.Write($"Prazer, {nome}! Em qual ano vocÃª comeÃ§ou a programar? ");
string entradaAno = Console.ReadLine();


int anoInicio = int.Parse(entradaAno);

int anosDeJornada = DateTime.Now.Year - anoInicio;

Console.WriteLine("\n----------------------------------------");
Console.WriteLine($"STATUS DO PERFIL: {nome.ToUpper()}");
Console.WriteLine($"TEMPO DE ESTRADA: {anosDeJornada} ano(s) de experiÃªncia.");
Console.WriteLine("----------------------------------------");

Console.WriteLine("\n[MissÃ£o Cumprida! Pressione qualquer tecla para encerrar]");
Console.ReadKey();

