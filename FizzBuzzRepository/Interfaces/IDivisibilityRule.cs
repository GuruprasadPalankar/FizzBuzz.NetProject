using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzRepository.Interfaces
{
    public interface IDivisibilityRule
    {
        Tuple<bool, string> GetOutput(int num);
    }
}
