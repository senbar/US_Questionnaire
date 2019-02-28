using DAP;
using Model.QuestionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.QuestionHelpers
{
    public static class AnswerHelper
    {
        public static List<Answer> GetAnswers()
        {
            return SQL.Query<Answer>("SELECT a_question as 'Question', a_answer as 'Answer' FROM Answers");
        }
    }
}
