
namespace cursoCsharp.Codigos
{
    //interface é um contrato( é obrigada a seguir a "forma" da interface.) que define métodos, propriedades, eventos ou indexadores
    //que uma classe deve implementar.

    //criar aqui a interface que passa a coisa padrão.
    public interface ISelect
    {
        string GerarSelect();
    }

    public class SelectGenerico : ISelect
    {
        private string nomeTabela;
        private string campoFiltro;
        private string valorFiltro;

        //Criando o construtor para criar um objeto SelectGenerico
        public SelectGenerico(string nomeTabela, string campoFiltro, string valorFiltro)
        {
            this.nomeTabela = nomeTabela;
            this.campoFiltro = campoFiltro;
            this.valorFiltro = valorFiltro;
        }

        public string GerarSelect()
        {
            return $"SELECT * FROM {nomeTabela} WHERE {campoFiltro} = '{valorFiltro}'";
        }
    }
    class Program
    {
        public static void Rodar()
        {
            ISelect selectPessoa = new SelectGenerico("Pessoa", "Idade", "20");
            Console.WriteLine(selectPessoa.GerarSelect());

            ISelect selectProduto = new SelectGenerico("Produto", "Categoria", "Eletrônicos");
            Console.WriteLine(selectProduto.GerarSelect());

        }
    }
}


