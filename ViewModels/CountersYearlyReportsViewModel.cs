using System;
using System.Collections.Generic;
using Printercounter.ViewModels;

namespace Printercounter.ViewModels
{
    public class  CountersYearlyReportsViewModel 

    {
       public  List<MonthsValueViewModel>.Enumerator MonthsValue { get; set; }
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Years { get; set; }
        public List<string> Months { get; set; }
    }

     public class MonthsValueViewModel
     {
         public List<string> Monts { get; set; }
         public List<string> MontsValue { get; set; }
     }
}
