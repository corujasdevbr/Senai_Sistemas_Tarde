using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.Mvc.Repositorio;
using Senai.OO.Pizzaria.Mvc.Util;
using Senai.OO.Pizzaria.Mvc.ViewModels;

namespace Senai.OO.Pizzaria.Mvc.ViewsControllers
{
    public static class UsuarioViewController
    {

        /// <summary>
        /// Tela de cadastro de usuário
        /// </summary>
        public static void CadastrarUsuario(){
            string email, nome, senha;

            do
            {
                System.Console.WriteLine("Informe seu nome");
                nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome inválido");
                }
                
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Informe seu e-mail");
                email = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }

            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Informe a senha");
                senha = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarSenha(senha)){
                    System.Console.WriteLine("Senha inválida");
                }
                
            } while (!ValidacaoUtil.ValidarSenha(senha));

            #region Controller
                //Cria um objeto do Tipo UsuarioViewModel
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
                //Atribui os valores as propriedades
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;

                //Criar um objeto do Tipo UsuarioRepositorio
                UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
                //Insere um novo usuario
                usuarioRepositorio.Inserir(usuarioViewModel);

                //Mostra mensagem ao usuário
                System.Console.WriteLine("Usuário Cadastrado");
            #endregion
        }

        public static void Listar(){
            //Crio um objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            
            //Retorna a lista de usuarios cadastrados
            List<UsuarioViewModel> lsUsuarios =   usuarioRepositorio.Listar();
            
            //Percorre a lista de usuários retorna
            foreach (UsuarioViewModel item in lsUsuarios)
            {
                //Mostra na tela os dados do usuário
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email}");    
            }
        }
    }
}