namespace Senai.OO.Pizzaria.Mvc.ViewModels
{
    /// <summary>
    /// Classe responsável pelas informações do Usuário
    /// Herda a classe BaseViewModel
    /// </summary>
    public class UsuarioViewModel : BaseViewModel
    {
        /// <summary>
        /// Email do usuário
        /// </summary>
         public string Email { get; set; }
         /// <summary>
         /// Senha do usuário
         /// </summary>
         public string Senha { get; set; }
    }
}