using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Skote.Services.Common
{
    public class BaseDto
    {
        public Int64 Id { get; set; }
        public DateTime? CreateOn { get; set; }
        public Int64 Createdby { get; set; }
        public DateTime? UpdateOn { get; set; }
        public Int64 Updateby { get; set; }
        public bool IsDeleted { get; set; }
    }
}