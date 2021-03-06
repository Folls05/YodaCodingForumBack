using System;
using System.Collections.Generic;

#nullable disable

namespace YodaCodingForumBack.Models
{
    public partial class ArticleAndTag
    {
        public string ArticleandtagId { get; set; }
        public string ArticleId { get; set; }
        public string TagId { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastupdateUser { get; set; }
        public DateTime LastupdateDate { get; set; }
        public int? Version { get; set; }

        public virtual Article Article { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
