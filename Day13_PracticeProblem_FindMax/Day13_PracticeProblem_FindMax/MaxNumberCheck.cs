using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_FindMax
{
    public class MaxNumberCheck
    {
       
        public double MaxFloatNumber(double firstValues, double secondValues, double thirdValues)
        {

            if (firstValues.CompareTo(secondValues) > 0 && firstValues.CompareTo(thirdValues) > 0)
            {
                return firstValues;
            }
            if (secondValues.CompareTo(firstValues) > 0 && secondValues.CompareTo(thirdValues) > 0)
            {
                return secondValues;
            }
            if (thirdValues.CompareTo(firstValues) > 0 && secondValues.CompareTo(firstValues) > 0)
            {
                return thirdValues;
            }
            throw new Exception("firstnumber,secondnumber and thirdnumber are same");
        }
    }
}
