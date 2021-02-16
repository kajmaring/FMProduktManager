using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TBackup
    {
        public byte? KBackup { get; set; }
        public string DDatum { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
