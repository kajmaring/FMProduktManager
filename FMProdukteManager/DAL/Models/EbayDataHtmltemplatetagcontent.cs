﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDataHtmltemplatetagcontent
    {
        public int KEbayHtmlTemplateTagContent { get; set; }
        public int? KEbayHtmlTemplate { get; set; }
        public string CTagName { get; set; }
        public int? KEbayItem { get; set; }
        public string CTagValue { get; set; }
        public string CTagOptions { get; set; }
    }
}
