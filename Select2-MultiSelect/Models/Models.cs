using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Select2_MultiSelect.Models
{
    public class Automobile
    {
        public int Id
        {
            get;
            set;
        }

        [Display(Name = "Make")]
        public string Make
        {
            get;
            set;
        }
    }

    public class Dealership
    {
        [Display(Name = "Available Auto Makes")]
        public List<Automobile> Automobiles
        {
            get;
            set;
        }

        public int[] SelectedAutomobiles
        {
            get;
            set;
        }
    }
}
