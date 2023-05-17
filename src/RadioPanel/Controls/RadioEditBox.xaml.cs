using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace RadioPanel.Controls
{
    /// <summary>
    /// Interaction logic for EditTextBox.xaml
    /// </summary>
    public partial class RadioEditBox : UserControl, ICommandSource
    {
        private bool editable = false;

        public RadioEditBox()
        {
            this.InitializeComponent();
            this.editable = !this.IsReadOnly;

            this.MaskedTextBox.PreviewKeyDown += this.MaskedTextBox_KeyDown;
            this.MaskedTextBox.PreviewMouseLeftButtonDown += this.MaskedTextBox_PreviewMouseLeftButtonDown;
        }

        public string Text
        {
            get => (string)this.GetValue(TextProperty);
            set => this.SetValue(TextProperty, value);
        }

        public TextAlignment TextAlignment
        {
            get => (TextAlignment)this.GetValue(TextAlignmentProperty);
            set => this.SetValue(TextAlignmentProperty, value);
        }

        public bool IsReadOnly
        {
            get => (bool)this.GetValue(IsReadOnlyProperty);
            set => this.SetValue(IsReadOnlyProperty, value);
        }

        public Key CommandKey
        {
            get => (Key)this.GetValue(CommandKeyProperty);
            set => this.SetValue(CommandKeyProperty, value);
        }

        public Key ResetKey
        {
            get => (Key)this.GetValue(ResetKeyProperty);
            set => this.SetValue(ResetKeyProperty, value);
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

        private void MaskedTextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!this.editable || (this.MaskedTextBox.IsKeyboardFocusWithin && !this.IsReadOnly))
            {
                e.Handled = true;
                return;
            }

            e.Handled = true;

            this.IsReadOnly = false;
            this.MaskedTextBox.Text = string.Empty;
            this.MaskedTextBox.Focus();
            this.MaskedTextBox.SelectAll();
        }

        private void MaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == this.CommandKey)
            {
                BindingExpression bindingExpression = this.MaskedTextBox.GetBindingExpression(TextBox.TextProperty);
                bindingExpression.UpdateSource();
                this.IsReadOnly = true;
                this.Command?.Execute(this.CommandParameter);
            }
            else if (e.Key == this.ResetKey)
            {
                BindingExpression bindingExpression = this.MaskedTextBox.GetBindingExpression(TextBox.TextProperty);
                bindingExpression.UpdateTarget();
                this.IsReadOnly = true;
            }
        }

        public static readonly DependencyProperty CommandKeyProperty = DependencyProperty.Register(
            "CommandKey",
            typeof(Key),
            typeof(RadioEditBox),
            new PropertyMetadata(Key.Enter));

        public static readonly DependencyProperty ResetKeyProperty = DependencyProperty.Register(
            "ResetKey",
            typeof(Key),
            typeof(RadioEditBox),
            new PropertyMetadata(Key.Escape));

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command",
            typeof(ICommand),
            typeof(RadioEditBox),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register(
            "CommandParameter",
            typeof(object),
            typeof(RadioEditBox),
            new PropertyMetadata(null));

        public static readonly DependencyProperty CommandTargetProperty = DependencyProperty.Register(
            "CommandTarget",
            typeof(IInputElement),
            typeof(RadioEditBox),
            new PropertyMetadata(null));

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(RadioEditBox),
            new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static readonly DependencyProperty TextAlignmentProperty = DependencyProperty.Register(
            "TextAlignment",
            typeof(TextAlignment),
            typeof(RadioEditBox),
            new PropertyMetadata(TextAlignment.Left));

        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
            "IsReadOnly",
            typeof(bool),
            typeof(RadioEditBox),
            new PropertyMetadata(false));
    }
}
