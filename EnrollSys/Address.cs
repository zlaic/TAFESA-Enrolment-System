using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    public class Address
    {
        public const int DEF_STNUM = 0;
        public const string DEF_STNAME = "none";
        public const string DEF_SUB = "none";
        public const string DEF_POSTCODE = "0";
        public const string DEF_STATE = "none";
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address() : this(DEF_STNUM,DEF_STNAME,DEF_SUB,DEF_POSTCODE,DEF_STATE){ }
        public Address(int streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        public override string ToString()
        {
            return $"{StreetNum} {StreetName}, {Suburb}, {Postcode}, {State}";
        }
    }

}
