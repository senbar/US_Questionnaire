using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.ViewModels
{
    public class ResultViewModel : ObservableObject
    {
        private ObservableCollection<string> radioAnswers;
        public ObservableCollection<string> RadioAnswers
        {
            get { return radioAnswers; }
        }

        private ObservableCollection<string> checkAnswers;
        public ObservableCollection<string> CheckAnswers
        {
            get { return checkAnswers; }
        }

        public ResultViewModel()
        {
            radioAnswers = new ObservableCollection<string>();
            checkAnswers = new ObservableCollection<string>();
        }
    }
}
