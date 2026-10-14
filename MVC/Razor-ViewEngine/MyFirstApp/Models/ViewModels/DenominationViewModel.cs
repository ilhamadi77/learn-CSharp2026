using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models.ViewModels
{
    public class DenominationViewModel
    {
        public decimal Amount { get; set; }

        public List<DenominationItem> ResultDenominations { get; set; }  = new List<DenominationItem>();
    }
}