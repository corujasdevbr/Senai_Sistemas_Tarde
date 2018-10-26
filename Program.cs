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
            int opcaoDeslogado = 0;

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



            UsuarioViewController.CadastrarUsuario();
            UsuarioViewController.Listar();
        }
    }
}
