using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Order
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        [Display(Name = "Está Pronto  ?")]
        public bool IsDone { get; set; }
        [StringLength(300)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        public Pizza Pizza { get; set; }
        [Required(ErrorMessage = "Selecione uma pizza.")]
        [Display(Name = "Pizza")]
        public int PizzaId { get; set; }
        public Customer Customer { get; set; }
        [Required(ErrorMessage = "Selecione um cliente.")]
        [Display(Name = "Cliente")]
        public int CustomerId { get; set; }
        public Size Size { get; set; }
        [Required(ErrorMessage = "Escolha o tamanho.")]
        [Display(Name = "Tamanho")]
        public int SizeId { get; set; }




    }
}