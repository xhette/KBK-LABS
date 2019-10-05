using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Models
{
    public class FinalViewModel
    {
        public List<MatrixModel> RandomMatrices { get; set; }

        public List <MatrixModel> IncMatrices { get; set; }

        public List <MatrixModel> DecMatrices { get; set; }

        public List<Rows> RankLoads { get; set; }

        public List<Rows> MaxRandomLoads { get; set; } 

        public List<Rows> MaxIncLoads { get; set; }

        public List<Rows> MaxDecLoads { get; set; }
    }
}
