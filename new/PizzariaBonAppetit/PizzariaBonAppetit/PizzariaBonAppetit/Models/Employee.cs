using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Employee
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Por favor digite o CPF.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Por favor digite o nome.")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

    
        [Required(ErrorMessage = "Por favor digite o salário.")]
        [Display(Name = "Salário")]
        public double? Salary { get; set; }

        


    }
}