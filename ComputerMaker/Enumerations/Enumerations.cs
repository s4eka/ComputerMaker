using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaker.Enumerations
{
    enum Socet
    {
        LGA2066,
        LGA1151,
        LGA1151v2,
        LGA1150,
        LGA2011_3,
        LGA2011,
        LGA1155,
        TR4,
        AM4,
        FM2plus,
        FM2,
        AM3plus,
        AM3,
        AM2plus,
        AM1,
        AM2,
        FM1,
        LGA775,
        LGA1356,
        LGA1156,
        LGA3647,
        BGA1023,
        BGA1170,
        A462_370,
        FT1,
        G34,
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
