using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Pizza
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id{ get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Por favor digite o nome.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
      
        [Required(ErrorMessage = "Por favor digite o preço.")]
        [Display(Name = "Preço")]
        public double? Prize { get; set; }
        [StringLength(300)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }


    }
}