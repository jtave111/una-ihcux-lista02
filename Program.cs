// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("   SISTEMA EXPERT: Módulo de Boas-Vindas");
Console.WriteLine("========================================\n");


Console.Write("Olá, Recruta! Qual é o seu nome de Desenvolvedor(a)? ");
string nome = Console.ReadLine();

Console.Write($"Prazer, {nome}! Em qual ano você começou a programar? ");
string entradaAno = Console.ReadLine();

int anoInicio = int.Parse(entradaAno);
int anosDeJornada = DateTime.Now.Year - anoInicio;

Console.WriteLine("\n----------------------------------------");
Console.WriteLine($"STATUS DO PERFIL: {nome.ToUpper()}");
Console.WriteLine($"TEMPO DE ESTRADA: {anosDeJornada} ano(s) de experiência.");
Console.WriteLine("----------------------------------------");

Console.WriteLine("\n[Missão Cumprida! Pressione qualquer tecla para encerrar]");
Console.ReadKey();
