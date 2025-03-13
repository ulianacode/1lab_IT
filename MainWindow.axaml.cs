using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SetApp
{
    public partial class MainWindow : Window
    {
        private Set<string> mySet;

        public MainWindow()
        {
            InitializeComponent();
            mySet = new Set<string>();
            UpdateSetContent();
        }

        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
            var input = InputBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                mySet.Add(input);
                InputBox.Text = string.Empty;
                UpdateSetContent();
            }
        }

        private void OnRemoveButtonClick(object sender, RoutedEventArgs e)
        {
            var input = InputBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                mySet.Remove(input);
                InputBox.Text = string.Empty;
                UpdateSetContent();
            }
        }

        private void OnClearButtonClick(object sender, RoutedEventArgs e)
        {
            mySet.Clear();
            UpdateSetContent();
        }

        private void UpdateSetContent()
        {
            SetContent.Text = mySet.IsEmpty ? "Множество пусто." : string.Join(", ", mySet.ToArray());
        }
    }
}
