﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
            AverageGrade = 0;
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
