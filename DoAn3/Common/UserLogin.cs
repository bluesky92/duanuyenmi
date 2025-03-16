using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn3.Common
{
    [Serializable] 
    public class UserLogin
    {
        public string UserID { set; get; }
        public string UserName { set; get; }
        //public string GroupID { set; get; }
    }
}