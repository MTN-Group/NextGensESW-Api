using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexGenAPi
{
    public partial class LoginDTO
    {
        public List<Meta>  Meta  { get; set; }
    }

    public partial class Meta
    {
        public string message { get; set; }
        public bool success { get; set; }
        public Experience experience { get; set; }
    }

    public partial class Experience
    {
        public User user { get; set; }
    }

    public partial class User
    {
        public string token_Ttype { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public long token_expires_in { get; set; }
        public bool success { get; set; }
        public string msisdn { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string subscription_type { get; set; }
        public string subscription_status { get; set; }
    }
}