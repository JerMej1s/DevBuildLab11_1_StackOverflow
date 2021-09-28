using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11_1_StackOverflow.Models;

namespace Lab11_1_StackOverflow.Controllers
{
    public class AnswerController : Controller
    {
         /*  Routes:
         *  
         *      /Answer/addanswerform?questionId=##        -- present user with a form to add an answer to a question with questionId = ##
         *      /Answer/addanswer        -- create a new answer to a question with questionId = ##
         *      /Answer/editanswerform       -- present use with a form to edit an answer
         *      /Answer/updateanswer     -- save edited answer
         *      /Answer/upvoteanswer?answerId=##     -- increment upvote for an answer with answerId = ##
         * 
         */
        public IActionResult AddAnswerForm(int questionId)
        {
            return View(questionId);
        }

        public IActionResult AddAnswer(Answer answer)
        {
            DAL.UpdateAnswer(answer);
            return Redirect($"/StackOverflow/question?questionId={answer.questionId}");
        }

        public IActionResult EditAnswerForm(int answerId)
        {
            Answer answer = DAL.GetAnswer(answerId);
            Question question = DAL.GetQuestion(answer.questionId);
            return View(question);
        }

        public IActionResult UpdateAnswer(Answer answer)
        {
            DAL.UpdateAnswer(answer);
            return Redirect($"/StackOverflow/question?questionId={answer.questionId}");
        }

        public IActionResult UpvoteAnswer(int answerId)
        {
            Answer answer = DAL.GetAnswer(answerId);
            answer.answerUpvotes++;
            DAL.UpdateAnswer(answer);
            return Redirect($"StackOverflow/question?questionId={answer.questionId}");
        }
    }
}
