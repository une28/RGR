using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace curs.Views
{
    public partial class RequestView : UserControl
    {
        public RequestView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}