using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista validacoes = new ValidacoesLista();

var lista = new List<int> { 5, -1, -8, 9 };
var resultadoEsperado = new List<int> { 5, 9 };

// Act
var resultado = validacoes.ListaContemDeterminadoNumero(lista, 10);
Console.WriteLine(resultado);
/*
foreach (var i in resultado)
{

    Console.WriteLine(i);
}*/