using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace EhodBoutiqueEnLigne.Models.ViewModels
{
    public class ProductViewModel
    {
        [BindNever]
        public int Id { get; set; }


        [Required(ErrorMessage = "Veiller renseigner le nom du produit")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }


        [Required(ErrorMessage = "Veiller renseigner le stock du produit ")]
        public string Stock { get; set; }

        [Required(ErrorMessage = "Veiller renseigner le prix du produit")]
        public string Price { get; set; }
    }
}
