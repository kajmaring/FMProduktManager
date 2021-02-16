using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TEan
    {
        public string CEan { get; set; }
        public DateTime? DImportdatum { get; set; }
        public DateTime? DLockDate { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
