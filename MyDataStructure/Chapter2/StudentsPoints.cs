using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyDataStructure.Chapter2
{
    public class StudentsPoints
    {
        private double[] _points;
        public void Add(params double[] points)
        {
            _points = new double[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                _points[i] = points[i];
            }
        }

        public double Averge()
        {
            double total=0;
            for (int i = 0; i < _points.Length; i++)
            {
                total += _points[i];
            }

            return total / _points.Length;
        }

        public double ReturnMax()
        {
            double max = _points[0];
            {
                for (int i = 1; i < _points.Length; i++)
                {
                    if (max<_points[i])
                    {
                        max = _points[i];
                    }
                }
            }
            return max;
        }

        public double ReturnMin()
        {
            double min = _points[0];
            for (int i = 1; i < _points.Length; i++)
            {
                if (min>_points[i])
                {
                    min = _points[i];
                }
            }
            return min;
        }
    }

    public class StuAllPoints
    {
        private double[][] _points;


    }

   
}
