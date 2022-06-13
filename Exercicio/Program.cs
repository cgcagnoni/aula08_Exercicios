
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string mensagem = String.Join("; ", listaDeFilmes);
    return mensagem;
}

Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
Console.WriteLine();

int quantidadeTotalDeFilmes()
{
    int qtd = 0;
    for(int i = 0; i < listaDeFilmes.Length; i++)
    {
        qtd += 1;
    }
    return qtd;
}

Console.WriteLine($"Quantidade total de filmes na lista: {quantidadeTotalDeFilmes()}");
Console.WriteLine();



