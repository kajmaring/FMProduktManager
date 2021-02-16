using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayVwHtmltemplatetag
    {
        public int KEbayHtmlTemplateTag { get; set; }
        public int? KEbayHtmlTemplate { get; set; }
        public string CTagType { get; set; }
        public string CTagName { get; set; }
        public string CTagExtension { get; set; }
    }
}
