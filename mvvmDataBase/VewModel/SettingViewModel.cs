using mvvmDataBase.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace mvvmDataBase.VewModel
{
    public class SettingViewModel : ViewModelBase
    {
        private Stack<Window> windowStack = new Stack<Window>();
        private string _themtxt="Светлая тема";
        public string ThemTxt
        {
            get { return _themtxt; }
            set
            {
                _themtxt = value;
                OnPropertyChanged(nameof(ThemTxt));
            }
        }
        private string thisThems = "Light";
        public ICommand switchTems { get; set; }
        public SettingViewModel()
        {
            switchTems = new RelsyCommand(SwithTems);
        }

        private void SwithTems(object obj)
        {
            if (thisThems == "Dark")
            {
                thisThems = "Light";
                ThemTxt = "Светлая тема";
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("Thems/LightThems.xaml", UriKind.Relative) });
            }
            else
            {
                thisThems = "Dark";
                ThemTxt = "Темная тема";
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary { Source = new Uri("Thems/DarkTems.xaml", UriKind.Relative) });
            }
        }
    }
}
