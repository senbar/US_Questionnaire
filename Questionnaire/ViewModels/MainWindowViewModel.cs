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
using Questionnaire.Models;

namespace Questionnaire.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private ObservableObject _questionView;
        public ObservableObject QuestionView
        {
            get { return _questionView; }
            set
            {
                _questionView = value;
                RaisePropertyChangedEvent("QuestionView");
            }
        }

        private Models.AnswersContext Answers = new Models.AnswersContext();

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
        
        private CheckViewModel checkViewModel;
        private RadioViewModel radioViewModel;
        private ResultViewModel resultViewModel;


        public MainWindowViewModel()
        {
            resultViewModel = new ResultViewModel();
            radioViewModel=new RadioViewModel();
            checkViewModel = new CheckViewModel();
            ViewModel = this;
            _questionView = radioViewModel;  
        }
        
        public ICommand NextSlideCommand
        {
            get { return new DelegateCommand(NextSlide); }
        }

        private void NextSlide()
        {
            //RadioViewModel debugVar = (RadioViewModel)QuestionView;
            //Debug.WriteLine(String.Format("value at 0: {0}, value at 1 {1}", debugVar.ButtonsStatus[0], debugVar.ButtonsStatus[1]));
            if (_questionView == radioViewModel)
            {
                QuestionView = checkViewModel;
                return;
            }
            if (_questionView == checkViewModel)
            {
                QuestionView = resultViewModel;

                int i = 0;
                for(; i<radioViewModel.ButtonsData.Count; i++)
                {
                    if (radioViewModel.ButtonsData[i] == true)
                    {
                        resultViewModel.RadioAnswers.Add(radioViewModel.ButtonsText[i]);
                    }
                    if(checkViewModel.ButtonsData[i]== true)
                    {
                        resultViewModel.CheckAnswers.Add(radioViewModel.ButtonsText[i]);
                    }
                }



            }
        }

        private void EndQuestions()
        {
            //add database connection

        }

   }
}
