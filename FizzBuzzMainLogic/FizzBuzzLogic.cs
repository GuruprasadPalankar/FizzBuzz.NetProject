using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzRepository.Interfaces;

namespace FizzBuzzMainLogic
{
    public class FizzBuzzLogic : IFizzBuzzLogic
    {
        private readonly IList<IDivisibilityRule> _callCorrectClass;

        public FizzBuzzLogic(IList<IDivisibilityRule> callCorrectClass)
        {
            this._callCorrectClass = callCorrectClass;
        }
        
        public IList<string> OutputList(int number)
        {
            var outputList = new List<string>();

            for(var i = 1; i <= number; i++)
            {
                var correctClass = this._callCorrectClass.FirstOrDefault(x => x.GetOutput(i).Item1);
                outputList.Add(correctClass == null ? i.ToString() : correctClass.GetOutput(i).Item2);
            }

            return outputList;
        }
    }
}
