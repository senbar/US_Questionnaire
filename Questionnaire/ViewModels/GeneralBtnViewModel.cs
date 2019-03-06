using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Questionnaire.ViewModels
{
    public class GeneralButtonViewModel:ObservableObject
    {
        //this should be pulled dynamically somehow
        private const int numberOfRadioButtons = 7;

        //trzeba bylo zrobic 2 listy bo binding wpfa nie obsluguje tupli
        private List<string> buttonsText;
        public List<string> ButtonsText
        {
            get
            {
                return buttonsText;
            }
        }

        private List<bool?> buttonsData;
        public List<bool?> ButtonsData
        {
            get
            {
                return buttonsData;
            }
        }
        

        public GeneralButtonViewModel()
        {
            //initializing list for radio button statuses 
            buttonsData = new List<bool?>(numberOfRadioButtons);
            buttonsText = new List<string>(numberOfRadioButtons);
            for (int i = 0; i < numberOfRadioButtons; i++)
            {
                buttonsText.Add(string.Empty);
                buttonsData.Add(false);
            }
        } 

    }
}
