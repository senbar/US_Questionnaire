using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Questionnaire.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private RadioViewModel _questionView;
        public RadioViewModel QuestionView
        {
            get { return _questionView; }
            set
            {
                _questionView = value;
                RaisePropertyChangedEvent("QuestionView");
            }
        }

        private Models.Answers Answers = new Models.Answers();

        ObservableObject _viewModel;
        public ObservableObject ViewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;
                RaisePropertyChangedEvent("ViewModel");
            }
        }
        public MainWindowViewModel()
        {
            ViewModel = this;
            _questionView = new RadioViewModel();
        }
        
        public ICommand NextSlideCommand
        {
            get { return new DelegateCommand(NextSlide); }
        }

        private void NextSlide()
        {
            RadioViewModel debugVar = (RadioViewModel)QuestionView;
            Debug.WriteLine(String.Format("value at 0: {0}, value at 1 {1}", debugVar.ButtonsStatus[0], debugVar.ButtonsStatus[1]));
        } 

   }
}
