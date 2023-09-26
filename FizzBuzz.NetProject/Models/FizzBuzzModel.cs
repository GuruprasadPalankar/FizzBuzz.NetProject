using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PagedList;


namespace FizzBuzz.NetProject.Models
{
    public class FizzBuzzModel
    {
        [Required(ErrorMessage = "Note: Number field cannot be empty")]
        [Range(1, 1000, ErrorMessage = "Note: Number should be in between 1 to 1000")]
        public int InputNumber { get; set; }

        public IPagedList<string> ResultList { get; set; }
    }
}