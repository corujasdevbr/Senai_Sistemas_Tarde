using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.Mvc.Repositorio;
using Senai.OO.Pizzaria.Mvc.Util;
using Senai.OO.Pizzaria.Mvc.ViewModels;
using Senai.OO.Pizzaria.Mvc.ViewsControllers;

namespace Senai.OO.Pizzaria.Mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaoLogado = 0;

            do
            {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:{
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }
                    case 2:{
                        //Vai para a tela de login e retorna o usuário caso válido
                        UsuarioViewModel usuarioViewModel = UsuarioViewController.Logar();
                        //Verifica se o usuário é válido
                        if(usuarioViewModel != null){
                            //Mostra mensagem de boas vindas
                            System.Console.WriteLine("Seja bem vindo " + usuarioViewModel.Nome);

                            do
                            {
                                //Mostra o menu do usuário logado
                                MenuUtil.MenuLogado();
                                //Aguarda opção do usuário
                                opcaoLogado = int.Parse(Console.ReadLine());

                                //Escolhe a opção do usuário
                                switch (opcaoLogado)
                                {
                                    case 0:{
                                        System.Console.WriteLine("Tchau");
                                        break;
                                    }
                                    default:{
                                        System.Console.WriteLine("Opção inválida");
                                        break;
                                    }
                                }
                                
                            //Fica no laço enquanto opção diferente de 0
                            } while (opcaoLogado != 0);
                        }

                        break;
                    }
                    case 3:{
                        UsuarioViewController.Listar();
                        break;
                    }
                    case 0:{
                        System.Console.WriteLine("Tchau");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Opção Inválida");
                        break;
                    }
                }

            } while (opcaoDeslogado != 0);

        }
    }
}
