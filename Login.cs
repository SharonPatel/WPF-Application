using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Sharon_MidtermV2
{
    class Login
    {
        private int _ID;
        private string _userName;
        private string _passWord;
        private int _superUser;

        public Login()
        {
        }

        public Login(int id, string username, string password, int supuser)
        {
            ID = id;
            UserName = username;
            PassWord = password;
            SuperUser = supuser;
        }
        public int ID { get => _ID; set => _ID = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string PassWord { get => _passWord; set => _passWord = value; }
        public int SuperUser { get => _superUser; set => _superUser = value; }

        public override string ToString()
        {
            string p1 = String.Format("{0,-9}{1,-10}{2,-10}{3,-10}", ID, UserName, PassWord, SuperUser);
            return p1;
        }


    }
}
