using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.QuestionModels
{
    public class Answer
    {
        public string Question { get; set; }
        public string Value { get; set; }

        //public Dictionary<string, string> Data => new Dictionary<string, string>() { new KeyValuePair<string, string>(Question, Value) };

        public Answer()
        {

        }

    }
}
