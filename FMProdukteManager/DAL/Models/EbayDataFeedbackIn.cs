﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EbayDataFeedbackIn
    {
        public int KFeedbackIn { get; set; }
        public string ItemId { get; set; }
        public string CommentingUser { get; set; }
        public int? CommentingUserScore { get; set; }
        public string CommentText { get; set; }
        public string CommentTime { get; set; }
        public string CommentType { get; set; }
        public string FeedbackId { get; set; }
        public string FeedbackRole { get; set; }
        public string TransactionId { get; set; }
    }
}
