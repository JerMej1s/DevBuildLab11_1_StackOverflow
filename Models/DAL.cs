using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab11_1_StackOverflow.Models
{
    public class DAL
    {
        public static MySqlConnection database;
        
        public static IEnumerable<Question> GetQuestions()
        {
            return database.GetAll<Question>();
        }

        public static Question GetQuestion(int questionId)
        {
            return database.Get<Question>(questionId);
        }

        public static void InsertQuestion(Question question)
        {
            database.Insert(question);
        }

        public static void UpdateQuestion(Question question)
        {
            database.Update(question);
        }

        public static void DeleteQuestion(int questionId)
        {
            Question question = new Question() { questionId = questionId };
            database.Delete(question);
        }

        public static Answer GetAnswer(int answerId)
        {
            return database.Get<Answer>(answerId);
        }

        public static IEnumerable<Answer> GetAnswersForQuestion(int questionId)
        {
            var keyValues = new { questionId = questionId };

            string sql = "select * from answers where question_id = @questionId";

            IEnumerable<Answer> answers = database.Query<Answer>(sql, keyValues);

            return answers;
        }

        public static void InsertAnswer(Answer answer)
        {
            database.Insert(answer);
        }

        public static void UpdateAnswer(Answer answer)
        {
            database.Update(answer);
        }

        public static void DeleteAnswer(int answerId)
        {
            Answer answer = new Answer() { answerId = answerId };
            database.Delete(answer);
        }
    }
}
