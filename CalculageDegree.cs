using System;
using System.Collections.Generic;

namespace lesson12
{
    public class CalculageDegree
    {



        public CalculageDegree()
        {
        }


        public double getAverge(string subject, List<Student> students)
        {
            var sum = 0.0;
            foreach (var item in students)
            {
                if (subject == item.subject1)
                {
                    sum += item.degree1;
                }
                else if (subject == item.subject2)
                {
                    sum += item.degree2;
                }
                else if (subject == item.subject3)
                {
                    sum += item.degree3;
                }

            }

            return sum / 2;
        }

        public double MaxStudent(string subject, List<Student> students)
        {
            var max = 0.0;
            foreach (var item in students)
            {
                if (item.subject1 == subject)
                {
                    if (item.degree1 >= max)
                    {
                        max = item.degree1;
                    }
                }
                else if (item.subject2 == subject)
                {
                    if (item.degree2 >= max)
                    {
                        max = item.degree2;
                    }
                }

                else if (item.subject3 == subject)
                {
                    if (item.degree3 >= max)
                    {
                        max = item.degree3;
                    }
                }
            }
            return max;
        }

        public double MinStudnet(string subject, List<Student> students)
        {
            var min = 0.0;
            foreach (var item in students)
            {
                if (item.subject1 == subject)
                {
                    if (item.degree1 <= min)
                    {
                        min = item.degree1;
                    }
                }
                else if (item.subject2 == subject)
                {
                    if (item.degree2 <= min)
                    {
                        min = item.degree2;
                    }
                }

                else if (item.subject3 == subject)
                {
                    if (item.degree3 <= min)
                    {
                        min = item.degree3;
                    }
                }
            }

            return min;
        }
    }
}
