namespace MauiAppHotel.UI;

public partial class TelaSobre : ContentPage
{
	public TelaSobre()
	{
		InitializeComponent();
	}

    private void Voltar(object sender, EventArgs e)
    {

		try
		{

			Navigation.PopAsync();

		}
		catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");

		}

    }
}