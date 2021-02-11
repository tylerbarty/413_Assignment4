using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Assignment4.Models
{
    public class Suggestion
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string RauntName { get; set; }
        [Required]
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool badnumber { get; set; } = false;

    }
}
