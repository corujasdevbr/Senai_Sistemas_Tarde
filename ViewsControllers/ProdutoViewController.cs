using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.Mvc.Repositorio;
using Senai.OO.Pizzaria.Mvc.Util;
using Senai.OO.Pizzaria.Mvc.ViewModels;

namespace Senai.OO.Pizzaria.Mvc.ViewsControllers
{
    /// <summary>
    /// Classe responsável pelo View e Controller do Produto
    /// </summary>
    public static class ProdutoViewController
    {
        //Cria o objeto do tipo ProdutoRepositorio
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        public static void CadastrarProduto(){
            string nome, descricao, preco, categoria;

            #region View
                //Recebe o nome do produto
                do
                {
                    System.Console.WriteLine("Informe o nome do Produto");
                    nome = Console.ReadLine();
                    
                    if(string.IsNullOrEmpty(nome)){
                        System.Console.WriteLine("Nome do produto inválido");
                    }
                    
                } while (string.IsNullOrEmpty(nome));

                //Recebe a descrição do produto
                do
                {
                    System.Console.WriteLine("Informe a descricao do produto");
                    descricao = Console.ReadLine();
                    
                    if(string.IsNullOrEmpty(descricao)){
                        System.Console.WriteLine("Descrição inválida");
                    }
                } while (string.IsNullOrEmpty(descricao));

                //Recebe o preço do produto
                do
                {
                    System.Console.WriteLine("Informe o preço do produto");
                    preco = Console.ReadLine();
                    
                    if(string.IsNullOrEmpty(preco)){
                        System.Console.WriteLine("Preço inválido");
                    }
                } while (string.IsNullOrEmpty(preco));

                //Recebe a categoria
                do
                {
                    System.Console.WriteLine("Informe a categoria do produto");
                    categoria = Console.ReadLine();
                    
                    if(!ValidacaoUtil.ValidaCategoria(categoria)){
                        System.Console.WriteLine("Categoria inválida");
                    }

                } while (!ValidacaoUtil.ValidaCategoria(categoria));
            #endregion

            #region Controller
                //Cria a objeto ProdutoViewModel
                ProdutoViewModel produtoViewModel = new ProdutoViewModel();
                //Atribui os valores ao objeto produtoViewModel
                produtoViewModel.Nome = nome;
                produtoViewModel.Descricao = descricao;
                produtoViewModel.Preco = decimal.Parse(preco);
                produtoViewModel.Categoria = categoria;

                //Insere o produto atraves do Repositorio
                produtoRepositorio.Inserir(produtoViewModel);

                //Mostra mensagem para o usuário
                System.Console.WriteLine("Produto Cadastrado");
            #endregion
        }

        /// <summary>
        /// Lista todos os produtos
        /// </summary>
        public static void ListarProdutos(){
            List<ProdutoViewModel> lsProdutos = produtoRepositorio.Listar();

            foreach (ProdutoViewModel item in lsProdutos)
            {
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco.ToString("c")}");
            }

            

            int idProduto = 0;

            do
            {
                System.Console.WriteLine("Infome o Id do Produto para mais informações ou 0 para sair");

                //Obtêm o id do produto
                idProduto = int.Parse(Console.ReadLine());

                //caso seja 0 sai do laço
                if(idProduto == 0){
                    break;
                }

                //Declara um objeto ProdutoViewModel e busca o produto pelo id
                ProdutoViewModel produtoViewModel = produtoRepositorio.BuscarPorId(idProduto);

                //Verifica se o produto existe
                if(produtoViewModel != null){
                    //caso exista mostra todos os dados do produto
                    System.Console.WriteLine($@"{produtoViewModel.Id} 
                                                - {produtoViewModel.Nome}
                                                - {produtoViewModel.Descricao} 
                                                - {produtoViewModel.Preco.ToString("c")} 
                                                - {produtoViewModel.Categoria}");
                } else {
                    //Caso não exista informa ao usuário
                    System.Console.WriteLine("Produto não encontrado");
                }

            } while (idProduto != 0);
        }
    }
}