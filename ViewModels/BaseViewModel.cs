using System;

namespace Senai.OO.Pizzaria.Mvc.ViewModels
{
    /// <summary>
    /// Classe base que será herdada pelas outras classes
    /// Definida como Abstract para não poder ser instanciada 
    /// </summary>
    public abstract class BaseViewModel
    {
        /// <summary>
        /// Id do Objeto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do Objeto
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de criação do objeto
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}