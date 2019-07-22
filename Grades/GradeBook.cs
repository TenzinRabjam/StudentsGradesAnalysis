using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0f;
            foreach(float el in grades)
            {
                sum += el;
                stats.highestGrade = Math.Max(el, stats.highestGrade);
                stats.lowestGrade = Math.Min(el, stats.lowestGrade);
            }
            stats.averageGrade = sum / grades.Count;

            return stats;
        }

        private String _name;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.oldName = oldValue;
                        args.newName = value;
                        NameChanged(this, args);
                    }
                }
            }
        }

        public event NameChangedDelegate NameChanged;

        List<float> grades;
    }
}
