using System;
using System.Collections.Generic;
using System.Text;

namespace HW0329
{
    class User
    {
        public User(string userName)
        {
            this.UserName = userName;
        }
        private string _username;
        private string _password;

        public string UserName
        {
            get { return _username; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 6 && value.Length <= 25)
                    _username = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8 && value.Length <= 25 && HasDigit(value) == true && HasUpper(value) == true && HasLower(value) == true)
               
                    _password = value;
                
            }
        }



            public bool HasDigit(string str)
            {
            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsDigit(item))
                    return true ;
                }
            }
            return false ;
            }

           public bool HasUpper(string str)
           {
            
              if (!string.IsNullOrWhiteSpace(str))
              {
                foreach (var item in str)
                {
                    if (char.IsUpper(item))
                        return true;
                }
              }
            return false ;
           }

           public bool HasLower(string str)
           {
              if (!string.IsNullOrWhiteSpace(str))
              {
                foreach (var item in str)
                {
                    if (char.IsLower(item))
                        return true;
                }
              }
            return false;
           }
        }
  }

