using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Class1
    {
        private string string1;

        public string stringnude
        {
            get { return stringnude; }
            set { stringnude = value; }
        }

        public Class1(string first)
        {
            stringnude = first;
        }

        public string reverseString()
        {
            StringBuilder mh = new StringBuilder();
            mh.Append(string1);

            string revstring = mh.ToString();

            char[] sArray = mh.ToString().ToCharArray();

            Array.Reverse(sArray);

            string final = new string(sArray);

            mh.Replace(mh.ToString(), final);

            return final;
        }

    }
}
