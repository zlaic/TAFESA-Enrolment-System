using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    public class Subject
    {
        public const string DEF_CODE = "0";
        public const string DEF_NAME = "none";
        public const decimal DEF_COST = 0;
            
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal Cost { get; set; }

        public Subject(): this(DEF_CODE,DEF_NAME,DEF_COST) { }
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: {Cost:C}";
        }
    }

}
