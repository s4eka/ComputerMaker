using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ComputerMaker.Enumerations
{
    

    public class Socet
    {
        public static List<SelectListItem> socets { get; set; }
        public Socet()
        {
            socets  = new List<SelectListItem>();
            socets.Add(new SelectListItem { Text = "LGA2066", Value = "LGA2066" });
            socets.Add(new SelectListItem { Text = "LGA1151", Value = "LGA1151" });
            socets.Add(new SelectListItem { Text = "LGA1151v2", Value = "LGA1151v2" });
            socets.Add(new SelectListItem { Text = "LGA1150", Value = "LGA1150" });
            socets.Add(new SelectListItem { Text = "LGA2011_3", Value = "LGA2011_3" });
            socets.Add(new SelectListItem { Text = "LGA2011", Value = "LGA2011" });
            socets.Add(new SelectListItem { Text = "LGA1155", Value = "LGA1155" });
            socets.Add(new SelectListItem { Text = "TR4", Value = "TR4" });
            socets.Add(new SelectListItem { Text = "AM4", Value = "AM4" });
            socets.Add(new SelectListItem { Text = "FM2plus", Value = "FM2plus" });
            socets.Add(new SelectListItem { Text = "FM2", Value = "FM2" });
            socets.Add(new SelectListItem { Text = "AM3plus", Value = "AM3plus" });
            socets.Add(new SelectListItem { Text = "AM3", Value = "AM3" });
            socets.Add(new SelectListItem { Text = "AM2plus", Value = "AM2plus" });
            socets.Add(new SelectListItem { Text = "AM1", Value = "AM1" });
            socets.Add(new SelectListItem { Text = "AM2", Value = "AM2" });
            socets.Add(new SelectListItem { Text = "FM1", Value = "FM1" });
            socets.Add(new SelectListItem { Text = "LGA775", Value = "LGA775" });
            socets.Add(new SelectListItem { Text = "LGA1356", Value = "LGA1356" });
            socets.Add(new SelectListItem { Text = "LGA1156", Value = "LGA1156" });
            socets.Add(new SelectListItem { Text = "LGA3647", Value = "LGA3647" });
            socets.Add(new SelectListItem { Text = "BGA1023", Value = "BGA1023" });
            socets.Add(new SelectListItem { Text = "BGA1170", Value = "BGA1170" });
            socets.Add(new SelectListItem { Text = "A462_370", Value = "A462_370" });
            socets.Add(new SelectListItem { Text = "FT1", Value = "FT1" });
            socets.Add(new SelectListItem { Text = "G34", Value = "G34" });
        }
    }



    public  class FormFactor
    {
        public static List<SelectListItem> formFactors { get; set; }
        public FormFactor()
        {
            formFactors = new List<SelectListItem>();
            formFactors.Add(new SelectListItem { Text = "ATX", Value = "1" });
            formFactors.Add(new SelectListItem { Text = "mATX", Value = "2" });
            formFactors.Add(new SelectListItem { Text = "EATX", Value = "3" });
            formFactors.Add(new SelectListItem { Text = "BTX", Value = "4" });
            formFactors.Add(new SelectListItem { Text = "mBTX", Value = "5" });
            formFactors.Add(new SelectListItem { Text = "SSIEEB", Value = "6" });
            formFactors.Add(new SelectListItem { Text = "SSICEB", Value = "7" });
            formFactors.Add(new SelectListItem { Text = "FlexATX", Value = "8" });
            formFactors.Add(new SelectListItem { Text = "DTX", Value = "9" });
            formFactors.Add(new SelectListItem { Text = "Mini_DTX", Value = "10" });
            formFactors.Add(new SelectListItem { Text = "mini_ITX", Value = "11" });
            formFactors.Add(new SelectListItem { Text = "ThinMini_ITX", Value = "12" });
            formFactors.Add(new SelectListItem { Text = "miniSTX", Value = "13" });
            formFactors.Add(new SelectListItem { Text = "UCFF", Value = "14" });


        }
       
    }


    public class MemoryType
    {
        public static List<SelectListItem> memoryTypes { get; set; }
        public MemoryType()
        {
            memoryTypes = new List<SelectListItem>();
            memoryTypes.Add(new SelectListItem { Text = "DDR4 DIMM", Value = "DDR4 DIMM" });
            memoryTypes.Add(new SelectListItem { Text = "DDR3 DIMM", Value = "DDR3 DIMM" });
        }
        
    }
    public class Interfaces
    {
        public static List<SelectListItem> interfaces { get; set; }
        public Interfaces()
        {
            interfaces = new List<SelectListItem>();
            interfaces.Add(new SelectListItem { Text = "PCIe1", Value = "1" });
            interfaces.Add(new SelectListItem { Text = "PCIe2", Value = "2" });
            interfaces.Add(new SelectListItem { Text = "PCIe3", Value = "3" });
            interfaces.Add(new SelectListItem { Text = "SATA1", Value = "4" });
            interfaces.Add(new SelectListItem { Text = "SATA2", Value = "5" });
            interfaces.Add(new SelectListItem { Text = "SATA3", Value = "6" });


        }

    }

}
