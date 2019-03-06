using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.ViewModels
{
    class RadioViewModel : GeneralButtonViewModel
    {
        public RadioViewModel()
        {
            string[] questions = { "kielbasa", "pizza", "cleb", "bulka","pomidor","makaron","maslo" };
            for (int i = 0; i < this.ButtonsText.Count; i++)
            {
                this.ButtonsText[i] = questions[i]; 

            }
        }
    }
}
