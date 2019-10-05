using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Models
{
    public class Rows
    {
        List<int> Row { get; set; }
    }
    public class MatrixModel
    {
        public List<Rows> Column { get; set; }
    }
}
