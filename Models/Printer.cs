using System.ComponentModel.DataAnnotations;

namespace Printercounter.Models
{
    public class Printer
    {
        [Key]
        public int PrinterID { get; set; }
        public string PrinterIP { get; set; }
        public string PrinterName { get; set; }
        public string PrinterModel { get; set; }
        public string PrinterDescription { get; set; }
        public string PrinterSN { get; set; }
        public string PrinterBarcode { get; set; }
        public string PrinterLocation { get; set; }
        public string PrinterTonerName { get; set; }
    }
}
