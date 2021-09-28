using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Lab11_1_StackOverflow.Models
{
    [Table("answers")]
    public class Answer
    {
        [Key]
        public int answerId { get; set; }
        public int questionId { get; set; }
        public string username { get; set; }
        public string answerDetail { get; set; }
        public string answerPosted { get; set; }
        public int answerUpvotes { get; set; }
    }
}
