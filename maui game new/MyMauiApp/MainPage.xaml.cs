using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System;
using System.Linq;

namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	// ✅ These should be class-level fields
	private Button? lastClicked;
	private bool findingMatch = false;
	private int matchesFound = 0;

	public MainPage()
	{
		InitializeComponent();
		lastClicked = new Button();
	}

	private void PlayAgainButton_Clicked(object sender, EventArgs e)
	{
		AnimalButtons.IsVisible = true;
		PlayAgainButton.IsVisible = false;

		List<string> animalEmoji = new List<string> {
			"🐷", "🐷",
			"🐼", "🐼",
			"🐸", "🐸",
			"🐵", "🐵",
			"🐨", "🐨",
			"🐯", "🐯",
			"🐹", "🐹",
			"🐱", "🐱",
		};

		foreach (var button in AnimalButtons.Children.OfType<Button>())
		{
			int i = Random.Shared.Next(animalEmoji.Count);
			string nextEmoji = animalEmoji[i];
			button.Text = nextEmoji;
			button.BackgroundColor = Colors.LightBlue; // Reset color
			animalEmoji.RemoveAt(i);
		}

		Dispatcher.StartTimer(TimeSpan.FromSeconds(.1), TimerTick);
	}

	int tenthsOfSecondsElapsed = 0;

	private bool TimerTick()
	{
		if (!this.IsLoaded) return false;
		tenthsOfSecondsElapsed++;
		TimeElapsed.Text = "Time elapsed" + (tenthsOfSecondsElapsed / 10F).ToString("0,0s");

		if (PlayAgainButton.IsVisible)
		{
			tenthsOfSecondsElapsed = 0;
			return false;
		}

		return true;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (sender is Button buttonClicked)
		{
			if (!string.IsNullOrWhiteSpace(buttonClicked.Text) && !findingMatch)
			{
				buttonClicked.BackgroundColor = Colors.Red;
				lastClicked = buttonClicked;
				findingMatch = true;
			}
			else
			{
				if (buttonClicked != lastClicked && lastClicked != null && buttonClicked.Text == lastClicked.Text && (!String.IsNullOrWhiteSpace(buttonClicked.Text)))
				{
					matchesFound++;
					lastClicked.Text = " ";
					buttonClicked.Text = " ";
				}
				else if (lastClicked != null)
				{
					lastClicked.BackgroundColor = Colors.LightBlue;
				}

				findingMatch = false;
			}
		}

		if (matchesFound == 8)
		{
			matchesFound = 0;
			AnimalButtons.IsVisible = false;
			PlayAgainButton.IsVisible = true;
		}
	}
}
