using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayer.Models.DTO
{
    public class DivisorInputDTO
    {
        [Required(ErrorMessage ="Input number is a required field")]
        [Range(1, Int64.MaxValue, ErrorMessage ="Only Natural numbers greater than 0 are allowed")]
        public Int64 InputNumber { get; set; }
    }
}
