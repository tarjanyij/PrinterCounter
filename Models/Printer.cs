using System.ComponentModel.DataAnnotations;

namespace Printercounter.Models
{
    public class Printer
    {
        [Key]
        public int PrinterID { get; set; }

        [Display(Name = "IP address" )]
        public string PrinterIP { get; set; }

        [Display(Name = "Name" )]
        public string PrinterName { get; set; }
        
        [Display(Name = "Model Type" )]
        public string PrinterModel { get; set; }
        
        [Display(Name = "Description" )]
        public string PrinterDescription { get; set; }
        
        [Display(Name = "Serial Number" )]
        public string PrinterSN { get; set; }
        
        [Display(Name = "Inventory number" )]
        public string PrinterBarcode { get; set; }
        
         [Display(Name = "Location" )]
        public string PrinterLocation { get; set; }
        
         [Display(Name = "Toner name" )]
        public string PrinterTonerName { get; set; }
    }
}
