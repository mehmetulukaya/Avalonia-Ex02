using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using System.Collections.Generic;

namespace Avalonia_Ex02.Views
{
    public class ScrollViewerPageViewModel : ReactiveObject
    {
        private bool _allowAutoHide;
        private ScrollBarVisibility _horizontalScrollVisibility;
        private ScrollBarVisibility _verticalScrollVisibility;

        public ScrollViewerPageViewModel()
        {
            AvailableVisibility = new List<ScrollBarVisibility>
            {
                ScrollBarVisibility.Auto,
                ScrollBarVisibility.Visible,
                ScrollBarVisibility.Hidden,
                ScrollBarVisibility.Disabled,
            };

            HorizontalScrollVisibility = ScrollBarVisibility.Auto;
            VerticalScrollVisibility = ScrollBarVisibility.Auto;
            AllowAutoHide = true;
        }

        public bool AllowAutoHide
        {
            get => _allowAutoHide;
            set => this.RaiseAndSetIfChanged(ref _allowAutoHide, value);
        }

        public ScrollBarVisibility HorizontalScrollVisibility
        {
            get => _horizontalScrollVisibility;
            set => this.RaiseAndSetIfChanged(ref _horizontalScrollVisibility, value);
        }

        public ScrollBarVisibility VerticalScrollVisibility
        {
            get => _verticalScrollVisibility;
            set => this.RaiseAndSetIfChanged(ref _verticalScrollVisibility, value);
        }

        public List<ScrollBarVisibility> AvailableVisibility { get; }
    }
    public class Page1 : UserControl
{
    public Page1()
    {
        this.InitializeComponent();
        DataContext = new ScrollViewerPageViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
}
