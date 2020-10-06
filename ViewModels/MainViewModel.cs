using Avalonia;
using Avalonia.Controls;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        private bool paneopen=false;
        public bool PaneOpen
        {
            get => paneopen;
            set => this.RaiseAndSetIfChanged(ref paneopen, value);
        }

        public void PaneOpenClose()
        {
            PaneOpen = !PaneOpen;
        }


        // Window GetWindow() => (Window)this.GetWindow;

       
        public void MakeAMessage(string msg)
        {
            Message = msg;
            /*
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", msg);
            messageBoxStandardWindow.Show();
            */

            var msBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow(new MessageBoxStandardParams
                {
                    ButtonDefinitions = ButtonEnum.OkAbort,
                    ContentTitle = "Title",
                    ContentMessage = "Message",
                    Icon = Icon.Plus,
                    Style = Style.UbuntuLinux
                });
            msBoxStandardWindow.Show();

        }

        private int pageindex = 0;
        public int PageIndex
        {
            get => pageindex;
            set => this.RaiseAndSetIfChanged(ref pageindex, value);
        }

        public void PageChange()
        {
            if (PageIndex >= 2)
            { 
                PageIndex = 0;
            }
            else
                PageIndex++;
        }


    }

}
