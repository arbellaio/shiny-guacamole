using System;
using Demo.ViewModels.Base;
using Xamarin.Forms;

namespace Demo.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private string _textField;
        public string TextField
        {
            get { return _textField; }

            set
            {
                _textField = value;
                OnPropertyChanged(nameof(TextField));
            }
        }
        
        public Command ButtonClickCommand { get; }
        public HomeViewModel()
        {
            ButtonClickCommand = new Command (ChangeText);
        }

        private void ChangeText()
        {
            try
            {
                if (!string.IsNullOrEmpty(TextField))
                {
                    TextField = TextField.Length > 1
                        ? TextField.Substring(TextField.Length - 1) + TextField.Substring(1, TextField.Length - 2) + TextField.Substring(0, 1) : TextField;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}