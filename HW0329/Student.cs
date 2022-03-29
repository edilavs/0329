using System;
using System.Collections.Generic;
using System.Text;

namespace HW0329
{
    class Student
    {
        public string FullName;
        private string _groupNo;

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 5 && HasDigit(value) == true && HasLetter(value) == true)
                    _groupNo = value;
            }
        }


        public bool HasDigit(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsDigit(item))
                        return true;
                }
            }
            return false;
        }

        public bool HasLetter(string str)
        {

            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsLetter(item))
                        return true;
                }
            }
            return false;
        }
    }
}
