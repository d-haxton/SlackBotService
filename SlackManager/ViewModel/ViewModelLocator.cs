/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:SlackManager"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SlackManager.structuremap;

namespace SlackManager.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => Bootstrap.TheServiceLocator);
        }

        public MainViewModel MainDataContext => ServiceLocator.Current.GetInstance<MainViewModel>();
        public HistoryViewModel HistoryDataContext => ServiceLocator.Current.GetInstance<HistoryViewModel>();
        public ScriptViewModel ScriptDataContext => ServiceLocator.Current.GetInstance<ScriptViewModel>();
        public UserViewModel UserDataContext => ServiceLocator.Current.GetInstance<UserViewModel>();
        public WelcomeViewModel WelcomeDataContext => ServiceLocator.Current.GetInstance<WelcomeViewModel>();
        public QuizViewModel QuizDataContext => ServiceLocator.Current.GetInstance<QuizViewModel>();
        public AttendanceViewModel AttendanceDataContext => ServiceLocator.Current.GetInstance<AttendanceViewModel>();
        public TriviaViewModel TriviaDataContext => ServiceLocator.Current.GetInstance<TriviaViewModel>();
        public BadWordsViewModel BadWordsDataContext => ServiceLocator.Current.GetInstance<BadWordsViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}