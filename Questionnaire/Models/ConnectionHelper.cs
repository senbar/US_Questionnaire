using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Models
{
    static public class ConnectionHelper
    {
        static public AnswersContext GetAnswers()
        {
            string SqlConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (var connection = new SqlConnection())
            {
                string sql = "SELECT * FROM TestData";
            }
            return new AnswersContext();
        }
        static public void SaveAnswers(AnswersContext asnwers)
        {

        }
    }
}
