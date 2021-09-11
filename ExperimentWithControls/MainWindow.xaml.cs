using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ExperimentWithControls
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			number.Text = numberTextBox.Text;
		}

		private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			#pragma warning disable IDE0059 // Unnecessary assignment of a value
			e.Handled = !int.TryParse(e.Text, out int result);
			#pragma warning restore IDE0059 // Unnecessary assignment of a value
		}

		private void SmallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			number.Text = smallSlider.Value.ToString("0");
		}

		private void BigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			number.Text = bigSlider.Value.ToString("000-000-0000");
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			if (sender is RadioButton radioButton)
			{
				number.Text = radioButton.Content.ToString();
			}
		}

		private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (myListBox.SelectedItem is ListBoxItem listBoxItem)
			{
				number.Text = listBoxItem.Content.ToString();
			}
		}

		private void ReadOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem)
			{
				number.Text = listBoxItem.Content.ToString();
			}
		}

		private void EditableComboBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (sender is ComboBox comboBox)
			{
				number.Text = comboBox.Text;
			}
		}
	}
}