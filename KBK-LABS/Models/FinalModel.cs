using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Models
{
    public class FinalModel
    {
        public MatrixModel RandomMatrixShedule { get; set; }

        public MatrixModel IncMatrixShedule { get; set; }

        public MatrixModel DecMatrixShedule { get; set; }

        public int MaxRandomLoad { get; set; }

        public int MaxIncLoad { get; set; }

        public int MaxDecLoad { get; set; }

        public List<int> MaxLoadsRank { get; set; }
    }


    public class FinalTwoModel
    {
        public MatrixModel StartRandom{ get; set; }

        public MatrixModel StartInc { get; set; }

        public MatrixModel StartDec { get; set; }

        public FinalModel FinalShedule { get; set; }
    }
}
