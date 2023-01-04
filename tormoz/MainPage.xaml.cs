namespace tormoz;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		double type = 0;
		if(pick.SelectedIndex == 0)
		{

			type = 0.7;
		}
		else if(pick.SelectedIndex == 1)
		{
            type = 0.4;

        }
        else if (pick.SelectedIndex == 1)
        {
            type = 0.2;

        }
        else if (pick.SelectedIndex == 1)
        {
            type = 0.02;

        }
		int speedNum = int.Parse(speed.Text);


		result.Text = $"{(speedNum * speedNum) / (254 * type)}";
    }
}


