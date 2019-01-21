using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace nestedviewtest
{
    public class ValvesComponentsViewModel
    {
        
        public int valveid { get;  set; }
        public int valvecomponentsid { get;  set; }

        [Display(Name = "Position")]        
        [ScaffoldColumn(true)]
        public int Position { get;  set; }

        [Display(Name = "Item")]        
        [ScaffoldColumn(true)]
        public string Item { get;  set; }

        [Display(Name = "TBD Item")]        
        [ScaffoldColumn(true)]
        public string TBDItem { get;  set; }


        [Display(Name = "Item Type")]        
        [ScaffoldColumn(true)]
        public string ItemType { get;  set; }


        [Display(Name = "Sourcing")]        
        [ScaffoldColumn(true)]
        public string Sourcing { get;  set; }


        [Display(Name = "TBD Item Type")]        
        [ScaffoldColumn(true)]
        public string TBDITEMType { get;  set; }

        [Display(Name = "Qty")]        
        [ScaffoldColumn(true)]
        public double Qty { get;  set; }

        [Display(Name = "TBD Qty")]        
        [ScaffoldColumn(true)]
        public double? TBDQty { get;  set; }


        [Display(Name = "Description")]        
        [ScaffoldColumn(true)]
        public string Description { get;  set; }

        [Display(Name = "Cost")]        
        [ScaffoldColumn(true)]
        public decimal? Cost { get;  set; }

        [Display(Name = "TBD Cost")]        
        [ScaffoldColumn(true)]
        public decimal? TBDCost { get;  set; }


        [Display(Name = "TBD Notes")]        
        [ScaffoldColumn(true)]
        public string TBDNotes { get;  set; }
        public string UpdatedBy { get; internal set; }
    }
}
