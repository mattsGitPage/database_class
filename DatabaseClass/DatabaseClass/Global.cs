using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseClass
{
    /*
     * making this a singleton.. justification: only one user can be logged in at a time
     * so there should only be one object to reference their data
     * this has all the other fields that will make validation easier as well
     */
    class Global
    {

        private static Global singleInstance = null;
        private Global() { }

        //variables a user will need
        private static int user_id;

        private string password;

        public static Global getInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new Global();
            }

            return singleInstance;
        }

        //getters and setter
        public int get_user_id() { return user_id; }
        public void set_user_id(int id) { user_id = id; }

        public void set_user_password(string pass) { password = pass; }
        public string get_user_password() { return password; }


    }
}
