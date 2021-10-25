using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoAppMastek.Models
{
    public class EmpMetaData
    {
        [BindRequired,Required]

        public int Empno { get; set; }

        [Required(ErrorMessage ="EmpName is Required")]
        public string Ename { get; set; }
    }
}
