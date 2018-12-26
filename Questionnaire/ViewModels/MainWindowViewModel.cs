using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private IAnswerSection _questionView;
        public IAnswerSection QuestionView
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
        } 

   }
}
