namespace Senai.OO.Pizzaria.Mvc.ViewModels
{
    /// <summary>
    /// Classe que representa a entidade Produtos
    /// Herda a classe BaseViewModel
    /// </summary>
    public class ProdutoViewModel : BaseViewModel
    {
        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; set; }
        /// <summary>
        /// Categoria do Produto
        /// </summary>
        public string Categoria { get; set; }
        
    }
}