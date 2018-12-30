using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Questionnaire.ViewModels
{
    public class RadioViewModel : IAnswerSection
    {
        //this should be pulled dynamically somehow
        private const int numberOfRadioButtons = 5;

        private List<bool?> buttonsStatus;
        public List<bool?> ButtonsStatus
        {
            get
            {
                return buttonsStatus;
            }
        }
        

        public RadioViewModel()
        {
            //initializing list for radio button statuses 
            buttonsStatus = new List<bool?>(numberOfRadioButtons);
            for (int i = 0; i < numberOfRadioButtons; i++)
                buttonsStatus.Add(false);
        } 

    }
}
