using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzRepository.Interfaces;

namespace FizzBuzzRepository
{
    public class BuzzClass : IDivisibilityRule
    {
        private readonly IWednesdayRule _wed;

        public BuzzClass(IWednesdayRule wed)
        {
            this._wed = wed;
        }

        public Tuple<bool, string> GetOutput(int num)
        {
            return Tuple.Create(num % 5 == 0, this._wed.IsWednesday() ? "wuzz" : "buzz");
        }
    }
}
