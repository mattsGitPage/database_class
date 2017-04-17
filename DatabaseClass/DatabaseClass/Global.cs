using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System;

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

        private List<String[]> contacts = null;
		private String SQLServerAuthentication = "server=localhost; database=datapptho; user=group1; password=Password1";

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

        public List<String[]> getInfo() { return contacts; }
        public void setInfo(String[] s) { contacts.Add(s);}

		public String get_sql_auth() { return SQLServerAuthentication; }
    }
}
