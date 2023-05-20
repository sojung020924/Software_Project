using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ClassLibrary2
{
    public struct location
    {
        public int location_x;
        public int location_y;
        public bool used; //테이블이 사용 중이 아니면 false, 사용 중이면 true
    }

    public struct Jangbaguni
    {
        public string menu_name;
        public int total_price;
        public string memo;
        public List<List<string>> options;
        public int count;
    }
    



}
