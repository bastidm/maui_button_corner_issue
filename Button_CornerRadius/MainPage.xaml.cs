namespace Button_CornerRadius;

public partial class MainPage : ContentPage
{
	int roundCount = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnListButtonClicked(object sender, EventArgs e)
	{
		var senderBtn = sender as Button;
		if (senderBtn == null)
		{
			return;
		}

		senderBtn.BackgroundColor = senderBtn.BackgroundColor == Colors.Coral ? Colors.YellowGreen : Colors.Coral;
	}

	private void OnRoundBtnClicked(object sender, EventArgs e)
	{
		roundCount++;

		if (roundCount == 1)
			RoundBtn.Text = $"Clicked {roundCount} time";
		else
			RoundBtn.Text = $"Clicked {roundCount} times";

		SemanticScreenReader.Announce(RoundBtn.Text);
	}
}

