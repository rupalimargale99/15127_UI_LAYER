using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreEFCF_DropDownDemo.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CategoryId { get; set; }

        [Column(TypeName ="VARCHAR(20)")]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
