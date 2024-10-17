using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTlab04._3
{
    internal interface IEncryptable
    {
        string Encrypt();//Phương thức mã hoá
        string Decrypt();//Phương thức giải mã
    }
}
