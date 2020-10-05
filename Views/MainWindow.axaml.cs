using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;

using System;
using ReactiveUI;
using Avalonia_Ex02.Views;

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

            StyleManager styles = new StyleManager(this);
            this.FindControl<Button>("themeChange").Click += delegate
            {
                styles.UseTheme(styles.CurrentTheme switch
                {
                    StyleManager.Theme.Citrus => StyleManager.Theme.Sea,
                    StyleManager.Theme.Sea => StyleManager.Theme.Rust,
                    StyleManager.Theme.Rust => StyleManager.Theme.Candy,
                    StyleManager.Theme.Candy => StyleManager.Theme.Magma,
                    StyleManager.Theme.Magma => StyleManager.Theme.Citrus,
                    _ => throw new ArgumentOutOfRangeException(nameof(styles.CurrentTheme))
                });
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
