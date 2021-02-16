using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSqlErrorMessages
    {
        public TSqlErrorMessages()
        {
            TSqlError = new HashSet<TSqlError>();
        }

        public int KErrorMessage { get; set; }
        public string CExceptionName { get; set; }
        public string CErrorMessage { get; set; }
        public string CSpName { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual ICollection<TSqlError> TSqlError { get; set; }
    }
}
