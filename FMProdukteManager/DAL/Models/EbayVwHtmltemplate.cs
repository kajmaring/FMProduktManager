using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayVwHtmltemplate
    {
        public int KEbayHtmlTemplate { get; set; }
        public string CHtmlTemplateName { get; set; }
        public string CHtmlTemplateDescription { get; set; }
        public DateTime DCreated { get; set; }
        public byte NIsDefault { get; set; }
        public DateTime? DUploaded { get; set; }
        public int? NEbayHtmlTemplateParent { get; set; }
        public int KEbayHtmlTemplateData { get; set; }
        public byte NDeleted { get; set; }
    }
}
