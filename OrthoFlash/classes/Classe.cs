using System;
using System.Collections.Generic;
using System.Text;

namespace OrthoFlash.classes
{
    public enum Classe
    {
        INC = 0,
        PS = 1,
        MS = 2,
        GS = 4,
        CP = 8,
        CE1 = 16,
        CE2 = 32,
        CM1 = 64,
        CM2 = 128,
        SIX = 256,
        CIN = 512,
        QUA = 1024,
        TRO = 2048,
        SEC = 5096,
        PRE = 10192,
        TER = 20384,
        ADU = 40768,
        CY1 = PS | MS | GS,
        CY2 = CP | CE1 | CE2,
        CY3 = CM1 | CM2 | SIX,
        CY4 = CIN | QUA | TRO,
        LYC = SEC | PRE | TER
    }
}
