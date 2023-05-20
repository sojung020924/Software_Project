using System.Collections.Generic;

namespace ClassLibrary2
{
    public class shared_list
    {
        
        
        public List<location> location_list = new List<location>();
        private List<location> sharedList = new List<location>();
        //public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();


        public List<location> GetList()
        {
            return sharedList;
        }
        public void updatesharedList(List<location> sharedList)
        {
            this.sharedList = sharedList;
        }
    }
}