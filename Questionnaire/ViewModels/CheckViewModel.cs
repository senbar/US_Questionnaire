using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.ViewModels
{
    class CheckViewModel : GeneralButtonViewModel
    {
        public CheckViewModel()
        {
            string[] questions = {"zolty", "niebieski","zielony","czerwony","czarny","bialy","fioletowy" };
            for(int i =0; i<this.ButtonsText.Count; i++)
            {
                this.ButtonsText[i] = questions[i];
            }
        }
    }
}
