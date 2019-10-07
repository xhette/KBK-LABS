using KBK_LABS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBK_LABS.Methods
{
    public class LabWorkTwo
    {
        public FinalTwoModel final;

        public LabWorkTwo (ArrayStartModel arrayStart)
        {
            Random rand = new Random();
            List<Columns> matrix = new List<Columns>();


            for (int i = 0; i < arrayStart.M; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < arrayStart.N; j++)
                {
                    int element = rand.Next(arrayStart.T1, arrayStart.T2);
                    row.Add(element);
                }

                matrix.Add(new Columns
                {
                    Row = row
                });
            }

            List<Columns> orderInc = matrix.OrderBy(p => p.Row.Sum()).ToList();
            List<Columns> orderDec = matrix.OrderByDescending(p => p.Row.Sum()).ToList();

            final = new FinalTwoModel
            {
                StartRandom = new MatrixModel 
                { 
                    Matrix = matrix
                },
                StartInc = new MatrixModel
                {
                    Matrix = orderInc
                },
                StartDec = new MatrixModel
                {
                    Matrix = orderDec
                }
            };
            
        }

        private List<Columns> Shedule (MatrixModel matrix)
        {
            List<Columns> shedule = new List<Columns>();

            int n = matrix.Matrix[0].Row.Count;
            int m = matrix.Matrix.Count;
            int minElement = matrix.Matrix[0].Row.Min();
            int minIndex = matrix.Matrix[0].Row.IndexOf(minElement);

            List<int> firstStep = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i != minIndex) firstStep.Add(0);
                else firstStep.Add(minElement);
            }
        }

        public void Go()
        {
            //final.FinalShedule = new FinalModel
            //{
            //    RandomMatrixShedule = new MatrixModel(),
            //    IncMatrixShedule = new MatrixModel(),
            //    DecMatrixShedule = new MatrixModel(),
            //    MaxLoadsRank = new List<int>()
            //};

            List<Columns> Rand = new List<Columns>();
            List<Columns> Inc = new List<Columns>();
            List<Columns> Dec = new List<Columns>();

        }
    }
}
