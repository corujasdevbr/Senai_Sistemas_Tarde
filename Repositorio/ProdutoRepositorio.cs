using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.Mvc.ViewModels;

namespace Senai.OO.Pizzaria.Mvc.Repositorio
{
    /// <summary>
    /// Classe responsável pela gravação e leitura dos dados do Produto
    /// </summary>
    public class ProdutoRepositorio
    {
        //Cria um objeto do tipo List<ProdutoViewModel>
        static List<ProdutoViewModel> lsProdutos = new List<ProdutoViewModel>();

        /// <summary>
        /// Insere um novo Produto
        /// </summary>
        /// <param name="produto">Dados do Produto</param>
        /// <returns>Retorna o produto atualizado</returns>
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            //Atribui ao Id a quantidade de itens da lista + 1
            produto.Id = lsProdutos.Count + 1;
            //Atribui a Data de Criação ao objeto
            produto.DataCriacao = DateTime.Now;
            //Adiciona o produto na lista
            lsProdutos.Add(produto);
            //Retorna o produto
            return produto;
        }

        /// <summary>
        /// Retorna a lista de produtos
        /// </summary>
        /// <returns>Retorna um List<ProdutoViewModel></returns>
        public List<ProdutoViewModel> Listar(){
            return lsProdutos;
        }

        /// <summary>
        /// Busca um produto pelo seu Id
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retorna um Produto</returns>
        public ProdutoViewModel BuscarPorId(int id){
            foreach (ProdutoViewModel item in lsProdutos)
            {
                if(item.Id == id){
                    return item;
                }
            }

            return null;
        }
    }
}