using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Avalonia.Controls;

namespace Avalonia_Ex02.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {
        private string secondmessage = "second str value";
        public string SecondMessage
        {
            get => secondmessage;
            set => this.RaiseAndSetIfChanged(ref secondmessage, value);
        }

        private bool _isLeft = true;
        private int _displayMode = 3; //CompactOverlay

        public bool IsLeft
        {
            get => _isLeft;
            set
            {
                this.RaiseAndSetIfChanged(ref _isLeft, value);
                this.RaisePropertyChanged(nameof(PanePlacement));
            }
        }

        public int DisplayMode
        {
            get => _displayMode;
            set
            {
                this.RaiseAndSetIfChanged(ref _displayMode, value);
                this.RaisePropertyChanged(nameof(CurrentDisplayMode));
            }
        }

        public SplitViewPanePlacement PanePlacement => _isLeft ? SplitViewPanePlacement.Left : SplitViewPanePlacement.Right;

        public SplitViewDisplayMode CurrentDisplayMode
        {
            get
            {
                if (Enum.IsDefined(typeof(SplitViewDisplayMode), _displayMode))
                {
                    return (SplitViewDisplayMode)_displayMode;
                }
                return SplitViewDisplayMode.CompactOverlay;
            }
        }
    }
}
