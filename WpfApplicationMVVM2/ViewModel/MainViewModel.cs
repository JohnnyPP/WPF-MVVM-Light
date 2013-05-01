using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WpfApplicationMVVM2.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// To install MVVM Light, run the following command in the Package Manager Console
    /// PM> Install-Package MvvmLight
    /// See http://www.galasoft.ch/mvvm
    /// http://www.lapthorn.net/archives/579
    /// http://mvvmlight.codeplex.com/
    /// http://www.codeproject.com/Articles/323187/MVVMLight-Using-Two-Views
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            IncrementValue = new RelayCommand(() => IncrementValueExecute(), () => true);   //binding with button in XAML -> Command="{Binding IncrementValue}"
            ExampleValue = 0;                                                               //binding with textblock in XAML -> Text="{Binding ExampleValue}"

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        #region logic

        public ICommand IncrementValue { get; private set; }        

        private void IncrementValueExecute()
        {
            ExampleValue += 1;
        }

        private int _exampleValue;

        public int ExampleValue
        {
            get { return _exampleValue; }
            set
            {
                if (_exampleValue == value)
                    return;
                _exampleValue = value;
                RaisePropertyChanged("ExampleValue");
            }
        }

        #endregion

    }
}