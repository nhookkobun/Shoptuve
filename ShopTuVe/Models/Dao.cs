using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BooksShopOnline.Models
{
    public class Dao
    {
        private const string V = "Dao Description";

        [ScaffoldColumn(false)]
        public int DaoID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string DaoName { get; set; }
        [Required, StringLength(1000), Display(Name = V),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public float? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}