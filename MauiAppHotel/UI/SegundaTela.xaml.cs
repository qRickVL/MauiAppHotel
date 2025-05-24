namespace MauiAppHotel.UI;

public partial class SegundaTela : ContentPage
{
	public SegundaTela()
	{
		InitializeComponent();
	}

    private void Finalizar(object sender, EventArgs e)
    {

		try
		{

			Navigation.PopAsync();

		} catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");

		}

    }
}