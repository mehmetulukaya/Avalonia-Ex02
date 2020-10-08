using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia_Ex02.ViewModels;

namespace Avalonia_Ex02.Views
{
    public class Page2 : UserControl
{
    public Page2()
    {
        this.InitializeComponent();
        DataContext = new Page2ViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
}
