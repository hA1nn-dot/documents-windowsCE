using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documentos
{
    interface IProduct
    {
        string getDescription();
        string getAmount();
        string getUnit();
        string getClave();
        string getBarcode();
    }
}
