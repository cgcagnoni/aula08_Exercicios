// See https://aka.ms/new-console-template for more information
// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula(string[] listaDosFilmes)
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.string.join?view=net-6.0
    return String.Join("; ", listaDosFilmes);
}

// 1.1. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes(string[] listaDosFilmes)
{
    return listaDosFilmes.Length;
}

// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme, string[] listaDosFilmes)
{
    if (indiceDoFilme > listaDosFilmes.Length || indiceDoFilme < 0)
    {
        return listaDosFilmes[listaDosFilmes.Length - 1];
    }
    return listaDosFilmes[indiceDoFilme]; ;
}

// 1.4. Adiciona um novo filme a lista pelo seu nome.
String adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme, ref string[] listaDosfilmes)
{
    //https://docs.microsoft.com/pt-br/dotnet/api/system.string.isnullorwhitespace?view=net-6.0
    //https://www.techiedelight.com/add-new-elements-array-csharp/
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

    if ( !String.IsNullOrEmpty(nomeDoFilme) && !String.IsNullOrWhiteSpace(nomeDoFilme) )
    {
        Array.Resize(ref listaDosfilmes,listaDosfilmes.Length+1);
        listaDosfilmes[listaDosfilmes.Length-1]=nomeDoFilme;
    }
    return apresentaTodosOsFilmesSeparadosPorPontoVirgula(listaDosfilmes);
}

// 1.5. Atualiza um filme a partir do seu índice na lista.
    // tipo de retorno modificado para string
    // o requisito exige retorno de uma string com formato determinado, depois do elemento alterado
String atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNomeFilme, ref string[] listaDosFilmes)
{
    if (indiceDoFilme < listaDosFilmes.Length && indiceDoFilme >=0 )
    {
        if (!String.IsNullOrEmpty(novoNomeFilme) && !String.IsNullOrWhiteSpace(novoNomeFilme))
        {
            listaDosFilmes[indiceDoFilme] = novoNomeFilme;
        }
    }
    return apresentaTodosOsFilmesSeparadosPorPontoVirgula(listaDosFilmes);
}

// 1.6. Listar todos os filmes com seu índice/posição na lista.
    // tipo de retorno ajustado para o requisito do código exemplo (string separada por \n)
String listarTodosOsFilmesComSeuIndiceNaLista(string[] listaDosFilmes)
{
    string listaDeTodosOsFilmes = "\n";
    int index = 0;
    foreach( string cadaFilme in listaDosFilmes )
    {
        listaDeTodosOsFilmes += $"{index} - {cadaFilme}\n";
        index++;
    }
    return listaDeTodosOsFilmes;
}


// 2. Resultado esperado em sua solução.
Console.WriteLine("------ Resultados da Atividade ------");

// Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula: {apresentaTodosOsFilmesSeparadosPorPontoVirgula(listaDeFilmes)}");

// Retorna o número 6.
Console.WriteLine($"2. Retorna a quantidade de filmes da lista: { quantidadeTotalDeFilmes(listaDeFilmes)}");

// Se o índice for 0, retorna Clube dos Cinco;
Console.WriteLine($"3. Buscar um filme pelo indice 0: {buscarNomeDoFilmePeloIndice(0, listaDeFilmes)}");

// Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine($"4. Adiciona um filme [Sexta-feira 13th] pelo nome: {adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th", ref listaDeFilmes)}");

// Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine($"5. Atualizar um filme pelo seu índice [3 = Rocky III]: {atualizarUmFilmePeloSeuIndice(3, "Rocky III", ref listaDeFilmes)}");

// Retorna 
// 0 - Clube dos Cinco 
// 1 - A Hora do Pesadelo 
// 2 - Karatê Kid
// 3 - Rocky III
// 4 - Conan, o Bárbaro
// 5 - Highlander
// 6 - Sexta-feira 13th
Console.WriteLine($"6. Listar todos os filmes com seu indice/posicao na lista: {listarTodosOsFilmesComSeuIndiceNaLista(listaDeFilmes)}");
