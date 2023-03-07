public class IntegracoesService : IIntegracoesService
{
    private const string jsonSucesso = @"{""sucesso"":true,""dados"":{""id"":1,""empresa"":""Premiersoft"",""vaga"":""Desenvolvedor C#""}}";
    private const string jsonErro = @"{""sucesso"":false,""mensagem"":""Ocorreu um erro na soliticação!""}";
    
    private readonly Random _rnd = new(420); 

    public string Executar()
    {
        return _rnd.Next() % 2 == 0 ? jsonSucesso : jsonErro;
    }
}