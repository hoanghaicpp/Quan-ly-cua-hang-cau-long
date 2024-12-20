using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopCauLong
{
    public class CustomParameter
    {
        public string key;
        public string value;

        public CustomParameter() { }
        
        public CustomParameter(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
