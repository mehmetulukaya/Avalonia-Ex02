using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;

namespace Avalonia_Ex02
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("myButton3").Click += delegate
              {
                  var msBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                      .GetMessageBoxStandardWindow(new MessageBoxStandardParams
                      {
                          CanResize = false,
                          ButtonDefinitions = ButtonEnum.OkAbort,
                          ContentTitle = "Title",
                          ContentMessage = "Message",
                          Icon = MessageBox.Avalonia.Enums.Icon.Plus,
                          WindowStartupLocation = WindowStartupLocation.CenterOwner,
                          Style = Style.None
                      });
                  msBoxStandardWindow.ShowDialog(this);
                  
              };
        
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
