using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace nestedviewtest
{    public class ValvesViewModel
    {
        // We removed ID field so WebApi demo works correctly
        [ScaffoldColumn(true)]
        [Display(Name = "Quote Number")]
        public string lnsalesquotationnumber
        {
            get;
            set;
        }


        [ScaffoldColumn(true)]
        [Display(Name = "Model")]        

        public string ValveModel
        {
            get;
            set;
        }

        [Display(Name = "Equipment")]        
        [ScaffoldColumn(true)]
        public string EquipmentNumber
        {
            get;
            set;
        }


        [Display(Name = "Qty")]        
        [ScaffoldColumn(true)]
        public double Qty
        {
            get;
            set;
        }

        [Display(Name = "Calculated Cost")]        
        [ScaffoldColumn(true)]
        public decimal? CalculatedCost
        {
            get;
            set;
        }

        [Display(Name = "Override Cost")]        
        [ScaffoldColumn(true)]
        public decimal? OverrideCost
        {
            get;
            set;
        }

        [Display(Name = "Accepted Cost")]        
        [ScaffoldColumn(true)]
        public decimal? AcceptedCost
        {
            get;
            set;
        }
        public int Valveid { get; internal set; }
    }
}
