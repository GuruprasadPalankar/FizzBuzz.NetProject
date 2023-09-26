using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMainLogic
{
    public interface IFizzBuzzLogic
    {
        IList<string> OutputList(int number);
    }
}
