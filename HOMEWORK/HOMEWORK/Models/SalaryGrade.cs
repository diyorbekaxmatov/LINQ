using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK.Models
{
    internal class SalaryGrade
    {
        public int Grade { get; set; }
        public decimal Losal{ get; set; }
        public decimal Hisal { get; set; }
        public override string ToString()
        {
            return $"Grade {Grade}, Losal  {Losal}, Hisal {Hisal}";
        }
    }
}
