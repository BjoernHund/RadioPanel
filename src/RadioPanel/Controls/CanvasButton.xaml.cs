using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RadioPanel.Controls
{
    /// <summary>
    /// Interaction logic for CanvasButton.xaml
    /// </summary>
    public partial class CanvasButton : UserControl, ICommandSource
    {
        public event RoutedEventHandler Click;

        public CanvasButton()
        {
            this.InitializeComponent();
        }

        public Geometry IconData
        {
            get => (Geometry)this.GetValue(IconDataProperty);
            set => this.SetValue(IconDataProperty, value);
        }

        public Brush HoverForeground
        {
            get => (Brush)this.GetValue(HoverForegroundProperty);
            set => this.SetValue(HoverForegroundProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)this.GetValue(CommandProperty);
            set => this.SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => this.GetValue(CommandParameterProperty);
            set => this.SetValue(CommandParameterProperty, value);
        }

        public IInputElement CommandTarget
        {
            get => (IInputElement)this.GetValue(CommandTargetProperty);
            set => this.SetValue(CommandTargetProperty, value);
        }

        public static readonly DependencyProperty IconDataProperty = DependencyProperty.Register(
            "IconData",
            typeof(Geometry),
            typeof(CanvasButton),
            new PropertyMetadata(Geometry.Parse("M13,3H11V13H13V3M17.83,5.17L16.41,6.59C18.05,7.91 19,9.9 19,12A7,7 0 0,1 12,19C8.14,19 5,15.88 5,12C5,9.91 5.95,7.91 7.58,6.58L6.17,5.17C2.38,8.39 1.92,14.07 5.14,17.86C8.36,21.64 14.04,22.1 17.83,18.88C19.85,17.17 21,14.65 21,12C21,9.37 19.84,6.87 17.83,5.17Z"))
        );

        public static readonly DependencyProperty HoverForegroundProperty = DependencyProperty.Register(
            "HoverForeground",
            typeof(Brush),
            typeof(CanvasButton),
            new PropertyMetadata(Brushes.White));

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(CanvasButton),
            new PropertyMetadata(null));


        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register(
            "CommandParameter",
            typeof(object),
            typeof(CanvasButton),
            new PropertyMetadata(null));


        public static readonly DependencyProperty CommandTargetProperty = DependencyProperty.Register(
            "CommandTarget",
            typeof(IInputElement),
            typeof(CanvasButton),
            new PropertyMetadata(null));

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            this.Click?.Invoke(this, e);
            this.Command?.Execute(this.CommandParameter);
        }
    }
}
