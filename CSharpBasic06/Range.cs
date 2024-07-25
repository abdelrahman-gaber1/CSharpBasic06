using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic06
{
    internal class NewRange<T>  where T : IComparable<T> 
    {
        public static T min { get; set; }
        public static T max { get; set; }

        public NewRange(T _min , T _max)
        {
            min = _min;
            max = _max;
        }
        public static  bool IsInRange(T value)
        {
            if (value.CompareTo(min) >= 0 && value.CompareTo(max) <=0 ) return true;
            else return false;
        }
        // can't do it
        //public T Lenght()
        //{
            
        //    return max - min; 
        //}
    }
}
