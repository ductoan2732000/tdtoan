using System;
using System.Collections.Generic;
using System.Text;
using static TDTOAN.Model.Enum.enumuration;

namespace TDTOAN.Model.Base
{
    public class service_response
    {
        public bool Success { get; set; } = true;
        public Object Data { get; set; } = null;
        public string msg { get; set; } = "";
        public SubCode SubCode { get; set; } = SubCode.Success;
    }
    
}
