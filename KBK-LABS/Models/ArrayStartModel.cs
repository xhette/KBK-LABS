using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Models
{
    public class ArrayStartModel
    {
        [Display(Name = "Количество процессоров (n)")]
        public int N { get; set; }

        [Display(Name = "Количество заданий (m)")]
        public int M { get; set; }

        [Display(Name = "Количество массивов (z)")]
        public int Z { get; set; }

        [Display(Name = "Нижняя граница (t1)")]
        public int T1 { get; set; }

        [Display(Name = "Верхняя граница (t2)")]
        public int T2 { get; set; }
    }
}
