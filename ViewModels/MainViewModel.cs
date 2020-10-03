using Avalonia;
using Microsoft.CodeAnalysis.Operations;
using ReactiveUI;
using System.Reactive;

namespace Avalonia_Ex02.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string message= "init str value";
        public string Message
        {
            get => message;
            set => this.RaiseAndSetIfChanged(ref message, value);
        }

        public void MakeAMessage(string msg)
        {
            Message = msg;
        }
    }

}
