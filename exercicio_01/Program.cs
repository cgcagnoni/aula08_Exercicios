// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string lista = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        // lista = listaDeFilmes[i] + "; ";
        lista += listaDeFilmes[i] + "; ";

    }
    return lista;
}

Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());

// 1.2 Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    int quantidadeFilmes = 0;
    quantidadeFilmes = listaDeFilmes.Length;
    return quantidadeFilmes;
}

Console.WriteLine("\nA quantidade de filmes da lista é: " + quantidadeTotalDeFilmes());

// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    return listaDeFilmes[indiceDoFilme];
}
Console.WriteLine(buscarNomeDoFilmePeloIndice(0));

// 1.4. Adiciona um novo filme a lista pelo seu nome.
String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    return listaDeFilmes.Append(nomeDoFilme).ToArray();
}


// 1.5. Atualiza um filme a partir do seu índice na lista.
String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNome)
{
    listaDeFilmes[indiceDoFilme] = novoNome;
    return listaDeFilmes;
}
