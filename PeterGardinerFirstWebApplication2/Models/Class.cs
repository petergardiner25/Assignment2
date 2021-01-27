using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeterGardinerFirstWebApplication2.Models
{
    //model for grade calculator
    public class Class
    {
        //range for allowed inputs
        [Range(0, 100)]
        public int assignment { get; set; }
        [Range(0,100)]
        public int quiz { get; set; }
        [Range(0, 100)]
        public int exams { get; set; }
        [Range(0, 100)]
        public int intex { get; set; }
     


    };
}
