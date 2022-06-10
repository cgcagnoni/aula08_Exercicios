// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string lista = ""; 
    for (int indice = 0; indice < listaDeFilmes.Length; indice++)
    {
        //lista = listaDeFilmes[indice] + ";"; -> assim só pega o último item (sobreposição)
        //lista = lista + listaDeFilmes[indice] + ";"; -> faz o mesmo que a linha de baixo
        lista += $"{listaDeFilmes[indice]}; ";
    }
    return lista;
}

Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());

