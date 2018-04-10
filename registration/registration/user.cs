using System;
using System.Collections.Generic;
using System.Text;

namespace registration
{
    class user
    {
        private string _username;
        private string _password;

        public string Username{
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }


    }
}
