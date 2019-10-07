using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Models
{
    public class Columns
    {
        public List<int> Row { get; set; }
    }
    public class MatrixModel
    {
        public List<Columns> Matrix { get; set; }
    }
}
