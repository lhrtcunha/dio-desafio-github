using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// See https://aka.ms/new-console-template for more information
// Pessoa p1 = new Pessoa();

// p1.Nome = "Bob";
// p1.Idade = 20;

// p1.Apresentar();

//Valores válidos
// Retangulo r = new Retangulo();
// r.DefinirMedidas(30,30);

// System.Console.WriteLine($"Área: {r.ObterArea()}");

// Aluno a1 = new Aluno();

// a1.Nome = "Bob";
// a1.Idade = 20;
// a1.Documento = "123456";
// a1.Nota = 10;

// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Leo";
// p1.Idade = 20;
// p1.Documento = "123456";
// p1.Salario = 2000;

// p1.Apresentar();

// Calculadora calc = new Calculadora();
// System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));

// System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));

// Corrente c = new Corrente();
// c.Creditar(1000);
// c.ExibirSaldo();

// Computador comp = new Computador();
// System.Console.WriteLine(comp.ToString());

// ICalculadora calc = new Calculadora(); 
// System.Console.WriteLine(calc.Somar(10,20));

var caminho = "/home/lhrtcunha/Projetos/DIO/dotnet/POO/TrabalhandoComArquivos";
var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3", "SubPasta teste 3");
var caminhoArquivo = Path.Combine(caminho, "arquivo teste-Stream.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo teste-Stream.txt");
var listaString = new List<String> {"Linhs 1","Linha 2","Linha 3"};
var listaStringContinuacao = new List<String> {"Linhs 4","Linha 5","Linha 6"};

FileHelper helper = new FileHelper();
// helper.ListarDiretorios(caminho);
// helper.ListarArquivosDiretorios(caminho);
// System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
// helper.CriarDiretorio(caminhoPathCombine);

// helper.ApagarDiretorio(caminhoPathCombine, true);
// helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita de arquivo.");

// helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
// helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

// helper.LerArquivoStream(caminhoArquivo);

// helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo,true);

// helper.CopiarArquivo(caminhoArquivo,novoCaminhoArquivo,true);

helper.DeletarArquivo(novoCaminhoArquivo);