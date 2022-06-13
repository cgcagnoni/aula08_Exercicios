
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string mensagem = String.Join("; ", listaDeFilmes);
    return mensagem;
}

Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
Console.WriteLine();




