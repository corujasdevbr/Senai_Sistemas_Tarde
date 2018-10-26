namespace Senai.OO.Pizzaria.Mvc.Util
{
    /// <summary>
    /// Classe responsável pelas validações do sistema
    /// </summary>
    public static class ValidacaoUtil
    {
        /// <summary>
        /// Metodo responsável por validar o email
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        /// <returns>Retorna true para email válido e false para e-mail inválido</returns>
        public static bool ValidarEmail(string email){
            //Se email recebido tiver @ e . retorna true
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }

            return false;
        }
        /// <summary>
        /// Valida a senha informada
        /// </summary>
        /// <param name="senha">Senha passada</param>
        /// <returns>Retorna true caso a senha esteja ok e false caso possua erro</returns>
        public static bool ValidarSenha(string senha){
            //Verifica se a senha passada é maior que 6 caracteres
            if(senha.Length >= 6){
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida a categoria informada
        /// </summary>
        /// <param name="categoria">Categoria deve ser Pizza ou Bebida</param>
        /// <returns>Retorna true caso a categoria seja Pizza/Bebida ou false não seja</returns>
        public static bool ValidaCategoria(string categoria){
            if(categoria.ToLower() == "pizza" || categoria.ToLower() == "bebida"){
                return true;
            }

            return false;
        }


        
    }
}