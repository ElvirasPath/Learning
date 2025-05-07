namespace MauiApp_controls_test;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BirdPicker.ItemsSource = new string[]
		{
			"Duck", 
			"Pigeon",
			"Penguin",
			"Ostrich",
			"Owl"
		};
	}

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		EnteredTextLabel.Text = e.NewTextValue;
	}

	private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		StepperValue.Text = e.NewValue.ToString();
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		SliderValue.Text = e.NewValue.ToString();
	}

	private void AddBird_OnClicked(object? sender, EventArgs e)
	{
		if (!String.IsNullOrEmpty(Birds.Text))
		{
			Birds.Text = Birds.Text + Environment.NewLine + BirdPicker.SelectedItem; //Environment.NewLine adds a line break. The Label control will display multiline text, adding a line break every time it sees a line break. BirdPicker.SelectedItem—this is the item that’s currently selected in the Picker control.
		}
		
		Birds.Text += BirdPicker.SelectedItem;
	}
}
