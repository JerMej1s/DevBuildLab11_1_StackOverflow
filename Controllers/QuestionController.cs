using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11_1_StackOverflow.Models;

namespace Lab11_1_StackOverflow.Controllers
{
    public class QuestionController : Controller
    {
        /*  Routes:
         * 
         *      /Question      -- list all questions
         *      /Question/question?questionId=##       -- list all answers for question with questionId = ##
         *      /Question/addquestionform      -- present user with a form to add a question
         *      /Question/addquestion      -- create a new question
         *      /Question/editquestionform     -- present user with a form to edit a question
         *      /Question/updatequestion       -- save edited question
         *      /Question/upvotequestion?questionId=##     -- increment upvote for a question with questionId = ##
         *      
         */
        public IActionResult Index()
        {
            IEnumerable<Question> questions = DAL.GetQuestions();
            return View(questions);
        }

        public IActionResult Question(int questionId)
        {
            IEnumerable<Answer> answers = DAL.GetAnswersForQuestion(questionId);
            return View(answers);
        }

        public IActionResult AddQuestionForm()
        {
            return View();
        }

        public IActionResult AddQuestion(Question question)
        {
            DAL.InsertQuestion(question);
            return Redirect($"/StackOverflow/question?questionId={question.questionId}");
        }

        public IActionResult EditQuestionForm(int questionId)
        {
            Question question = DAL.GetQuestion(questionId);
            return View(question);
        }

        public IActionResult UpdateQuestion(Question question)
        {
            DAL.UpdateQuestion(question);
            return Redirect($"/StackOverflow/question?questionId={question.questionId}");
        }

        public IActionResult UpvoteQuestion(int questionId)
        {
            Question question = DAL.GetQuestion(questionId);
            question.questionUpvotes++;
            DAL.UpdateQuestion(question);
            return Redirect($"/StackOverflow/question?questionId={question.questionId}");
        }
    }
}
