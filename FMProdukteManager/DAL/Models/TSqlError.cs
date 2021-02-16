using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TSqlError
    {
        public int KSqlError { get; set; }
        public int KErrorMessage { get; set; }
        public string CErrorData { get; set; }
        public byte[] BRowversion { get; set; }

        public virtual TSqlErrorMessages KErrorMessageNavigation { get; set; }
    }
}
