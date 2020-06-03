using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexGenAPi
{
   public partial class Products
    {
        public List <Response> Response { get; set; }
        public long StatusCode { get; set; }
    }

    public partial class Response
    {
        public long Product_Id { get; set; }
        public long Product_Has_Category { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public string Product_Icon { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Modified { get; set; }
        public long Display_Categories { get; set; }
        public long Default_Category_Id { get; set; }
    }
}
