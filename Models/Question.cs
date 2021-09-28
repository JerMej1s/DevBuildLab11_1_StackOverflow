using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Lab11_1_StackOverflow.Models
{
    [Table("questions")]
    public class Question
    {
        [Key]
        public int questionId { get; set; }
        public string username { get; set; }
        public string questionTitle { get; set; }
        public string questionDetail { get; set; }
        public DateTime questionPosted { get; set; }
        public int questionUpvotes { get; set; }
        public string category { get; set; }
        public string tag { get; set; }
    }
}
