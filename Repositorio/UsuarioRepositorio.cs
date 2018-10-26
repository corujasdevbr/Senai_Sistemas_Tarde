using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.Mvc.ViewModels;

namespace Senai.OO.Pizzaria.Mvc.Repositorio
{
    /// <summary>
    /// Classe responsável pela leitura e gravação dos dados
    /// referentes ao usuário
    /// </summary>
    public class UsuarioRepositorio
    {
        //Criação do objeto List<UsuarioViewModel> que faz parte do
        //namespace System.Collection.Generic
        static List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();

        /// <summary>
        /// Metódo para inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto UsuarioViewModel(nome, email, senha)</param>
        /// <returns>Retorna um UsuarioViewModel atualizado</returns>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            //Atribui um valor ao Id, verifica a quantidade de itens na
            //lista e soma 1
            usuario.Id = lsUsuarios.Count + 1;
            //Atribui a Data e Hora Atual do sistem
            usuario.DataCriacao = DateTime.Now;
            //Adiciona o usuário a List
            lsUsuarios.Add(usuario);
            //retorna o usuário
            return usuario;
        } 

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna um List<UsuarioViewModel></returns>
        public List<UsuarioViewModel> Listar(){
            return lsUsuarios;
        }

        /// <summary>
        /// Verifica se o usuário é válido
        /// </summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário caso seja valido e retorna null caso seja inválido</returns>
        public UsuarioViewModel Login(string email, string senha){
            //Percorre a lista de Usuários
            foreach (UsuarioViewModel item in lsUsuarios)
            {
                //Verifica se o item/objeto email e senha são iguais aos passados
                //como parametro
                if(item.Email == email && item.Senha == senha){
                    //retorna o item/UsuarioViewModel
                    return item;
                }
            }
            //Caso não encontre o usuário retorna null
            return null;
        }
    }
}