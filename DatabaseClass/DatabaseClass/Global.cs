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
        private static string gender;
        private static int min_age;

        public void setGender(String s) { gender = s; }
        public string getGender() { return gender; }
        public int getMinAge() { return min_age; }
        public void setMinAge(int s) { min_age = s; }
        public int getMaxAge() { return max_age; }
        public void setMaxAge(int s) { max_age = s; }
        public string getlocation() { return location; }
        public void setLocation(string s) { location = s; }
        public int getMaleType() { return male_gender; }

        public int getFemaleType() { return female_gender; }
        public string getIntent() { return intent; }
        public void setIntent(string s) { intent = s; }

        private static int max_age;
        private static string location;
        private static int male_gender;
        private static int female_gender;
        private static string intent;

        private List<String[]> contacts = null;


        //The following data members are for use in the transition from the profile browser to the profile viewer spawned in viewuser.cs

        private static Boolean flag_browse = false;
        public void setFlag(Boolean s) { flag_browse = s; }
        public Boolean getFlag() { return flag_browse; }

        private static int browse_id;
        public int get_browse_id() { return browse_id; }
        public void set_browse_id(int id) { browse_id = id; }

        private static List<int> ListOfIdsThatCameFromFilter = new List<int>();
        public List<int> getList() { return ListOfIdsThatCameFromFilter; }
        public void AddToList(int id) { ListOfIdsThatCameFromFilter.Add(id); }
        public void ClearList() { ListOfIdsThatCameFromFilter.Clear(); }


        //this allows Larry Matt and Gabe to only have to change one line of code to use the dbms on their machines. 
        //bad design but effective. 
        private String SQLServerAuthentication = "server=localhost; database=datapptho; user=root; password=mysql9001";

        public string get_sql_auth() { return SQLServerAuthentication; }

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
        public void setInfo(String[] s) { contacts.Add(s); }

    }
}