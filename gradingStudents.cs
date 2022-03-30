using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class gradingStudents
    {
        public static List<int> gradingStudent(List<int> grades)
        {
            //round grades up to the next multiple of 5
            //if the rounded grade is > 37, then round grade down to the next multiple of 5

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38 && grades[i] % 5 > 2)
                {
                    grades[i] = grades[i] + (5 - (grades[i] % 5));
                }
            }
            return grades;

            return new List<int>();
        }
    }
}
