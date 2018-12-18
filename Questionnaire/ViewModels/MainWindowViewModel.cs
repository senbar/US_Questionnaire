using System; using System.Collections.Generic;
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
        private string _questionView;
        public string QuestionView
        {
            get { return _questionView; }
            set
            {
                _questionView = value;
                RaisePropertyChangedEvent("QuestionView");
            }
        }

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

        //private UserControl __questionView;
        //public UserControl _QuestionView
        //{
        //    get { return __questionView; }
        //    set
        //    {
        //        __questionView = value;
        //        RaisePropertyChangedEvent("_QuestionView");

        //    }
        //}

        public MainWindowViewModel()
        {
            ViewModel = this;
            _questionView = "QuestionRadioView.xaml";
            //__questionView = new Questionnaire.Views.QuestionRadioView(); 
        }

        public ICommand NextSlideCommand
        {
            get { return new DelegateCommand(NextSlide); }
        }

        private void NextSlide()
        {
            QuestionView = "QuestionCheckView.xaml";
            //_QuestionView = new Questionnaire.Views.QuestionCheckView();
        } 


   }
}
