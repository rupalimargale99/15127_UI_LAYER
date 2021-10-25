using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreEFCF_DropDownDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MVCCoreEFCF_DropdownDemo.ViewModels
{
    public class DropdownViewModel
    {
        public string CategoryId { get; set; }
        public List<SelectListItem> CategoryList { get; set; }
        public List<Product> ProductList { get; set; }
    }
}