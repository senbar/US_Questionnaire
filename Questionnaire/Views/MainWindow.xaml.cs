using Questionnaire.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Questionnaire.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :UserControl 
    { 
        public MainWindow()
        {
            InitializeComponent();
            /*Important: if i bind content of question frame in xaml binding mechanism will create new instance of viemodel class with basically
            no way to bind them inside one class, relative data context binding doesnt work neither, you have to do it programitically*/

            var mainWindowViewModel = new MainWindowViewModel();
            this.DataContext = mainWindowViewModel;

            Binding QuestionBinding = new Binding("QuestionView");
            QuestionBinding.Source = mainWindowViewModel;
            this.QuestionContentFrame.SetBinding(Frame.ContentProperty, QuestionBinding);
        }
    }
}
