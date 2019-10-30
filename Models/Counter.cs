
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Printercounter.Models
{
    public class Counter
    {
        [Key]
        public int CounterID { get; set; }
        public int PrinterID { get; set; }
        public int PaperCounter { get; set; }
        public int TonerLevel { get; set; }
        public DateTime Date_Counter { get; set; }
        public int DailyPaperConsumption { get; set; }
        public Printer Printer { get; set; }

    }
    
}
