using System; using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Questionnaire
{
    public class MainWindowViewModel : INotifyPropertyChanged
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

         public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
         //   _questionView = "QuestionRadioView.xaml";
        }

        public ICommand NextSlideCommand
        {
            get { return new DelegateCommand(NextSlide); }
        }

        private void NextSlide()
        {
            QuestionView = "QuestionCheckView.xaml";
        } 


   }
}
