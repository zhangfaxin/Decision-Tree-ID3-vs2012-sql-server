using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTrees
{
    public class ID3_Algorithm
    {
        private DataMode data = new DataMode();
        
        public ID3_Algorithm()
        {

        }
        public double getEntropy(double yes, double no)
        {
            return getValue(yes, yes + no) + getValue(no, yes + no);
        }

        public double getValue(double numerator, double denominator)
        {
            if (numerator != 0)
            {
                return -(numerator / denominator) * Math.Log(numerator / denominator, 2) * 1.00;
            }
            else
            {
                return 0.0;
            }
        }
        
    }
}
