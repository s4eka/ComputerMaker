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
            socets.Add(new SelectListItem { Text = "LGA2066", Value = "0" });
            socets.Add(new SelectListItem { Text = "LGA1151", Value = "1"});
            socets.Add(new SelectListItem { Text = "LGA1151v2", Value = "2"});
            socets.Add(new SelectListItem { Text = "LGA1150", Value = "3"});
            socets.Add(new SelectListItem { Text = "LGA2011_3", Value = "4"});
            socets.Add(new SelectListItem { Text = "LGA2011", Value = "5"});
            socets.Add(new SelectListItem { Text = "LGA1155", Value = "6"});
            socets.Add(new SelectListItem { Text = "TR4", Value = "7"});
            socets.Add(new SelectListItem { Text = "AM4", Value = "8"});
            socets.Add(new SelectListItem { Text = "FM2plus", Value = "9"});
            socets.Add(new SelectListItem { Text = "FM2", Value = "10"});
            socets.Add(new SelectListItem { Text = "AM3plus", Value = "11"});
            socets.Add(new SelectListItem { Text = "AM3", Value = "12"});
            socets.Add(new SelectListItem { Text = "AM2plus", Value = "13"});
            socets.Add(new SelectListItem { Text = "AM1", Value = "14"});
            socets.Add(new SelectListItem { Text = "AM2", Value = "15"});
            socets.Add(new SelectListItem { Text = "FM1", Value = "16"});
            socets.Add(new SelectListItem { Text = "LGA775", Value = "17"});
            socets.Add(new SelectListItem { Text = "LGA1356", Value = "18"});
            socets.Add(new SelectListItem { Text = "LGA1156", Value = "19"});
            socets.Add(new SelectListItem { Text = "LGA3647", Value = "20"});
            socets.Add(new SelectListItem { Text = "BGA1023", Value = "21"});
            socets.Add(new SelectListItem { Text = "BGA1170", Value = "22"});
            socets.Add(new SelectListItem { Text = "A462_370", Value = "23"});
            socets.Add(new SelectListItem { Text = "FT1", Value = "24"});
            socets.Add(new SelectListItem { Text = "G34", Value = "25"});
        }
    }



    enum MotherBoardFormFactor
    {
        ATX,
        mATX,
        EATX,
        BTX,
        mBTX,
        SSIEEB,
        SSICEB,
        FlexATX,
        DTX,
        Mini_DTX,
        mini_ITX,
        ThinMini_ITX,
        miniSTX,
        UCFF
    }
    enum MemoryType
    {
        DDR4_DIMM,
        DDR4_SO_DIMM,
        DDR3_DIMM,
        DDR3_SO_DIMM,
        DDR4_DIMM_Registered,
        DDR3_DIMM_Registered,
        DDR3_SO_DIMM_Registered,
        DDR2_FB_DIMM,
        DDR2_DIMM_Registered,
        DDR2_DIMM,
        DDR2_SO_DIMM,
        DDR_DIMM_Registered,
        DDR_DIMM
    }
    enum Interfaces
    {
        Expressx16,
        Expressx8,
        Expressx4,
        Expressx1,
        Express30x16,
        Express30x8,
        Express30x4,
        Express30x1,
        PCI,
        PCIX,
        SATA20,
        SATA30,
        mSATA,
        SATAExpress,
        M2,
        SAS,
        eSATA
    }

}
