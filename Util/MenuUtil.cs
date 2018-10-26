using System;

namespace Senai.OO.Pizzaria.Mvc.Util
{
    /// <summary>
    /// Mostra os menus do sistema
    /// </summary>
    public static class MenuUtil
    {
        /// <summary>
        /// Monta o menu quando usuário estiver Deslogado
        /// </summary>
        public static void MenuDeslogado(){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria TkPizza---------------");
            Console.WriteLine("-------------      Conta      --------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Usuário            ");
            Console.WriteLine("           (2) Efetuar Login                ");
            Console.WriteLine("           (3) Listar                       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }

        /// <summary>
        /// Mostra o menu quando o usuário estiver Logado
        /// </summary>
        public static void MenuLogado(){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria Don Sena--------------");
            Console.WriteLine("-----------      Cardápio      -------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Produto            ");
            Console.WriteLine("           (2) Listar                       ");
            Console.WriteLine("           (3) Valor Total                  ");
            Console.WriteLine("           (4) Alterar                      ");
            Console.WriteLine("           (4) Remover                      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}