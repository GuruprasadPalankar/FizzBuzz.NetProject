using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzRepository.Interfaces;

namespace FizzBuzzRepository
{
    public class WizzWuzzClass : IWednesdayRule
    {
        public bool IsWednesday()
        {
            var day = DateTime.Today;
            return day.DayOfWeek.Equals(DayOfWeek.Wednesday);
        }
    }
}
