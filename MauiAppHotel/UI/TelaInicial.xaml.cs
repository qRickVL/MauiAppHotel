using MauiAppHotel.Models;

namespace MauiAppHotel.UI;

public partial class TelaInicial : ContentPage
{

	App PropriedadesApp;

	public TelaInicial()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		PckSuite.ItemsSource = PropriedadesApp.ListaSuites;

		DtpckCheckin.MinimumDate = DateTime.Now;
		DtpckCheckin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		DtpckCheckout.MinimumDate = DtpckCheckin.Date.AddDays(1);
		DtpckCheckout.MaximumDate = DtpckCheckin.Date.AddMonths(6);

	}

    private async void Avancar(object sender, EventArgs e)
    {

		try
		{

			Hospedagem hospedagem = new Hospedagem
			{

				SuiteSelecionada = (Suite)PckSuite.SelectedItem,
				QntAdultos = Convert.ToInt32(StpAdultos.Value),
				QntCriancas = Convert.ToInt32(StpCriancas.Value),
				DataCheckIn = DtpckCheckin.Date,
				DataCheckOut = DtpckCheckout.Date,

			};

			await Navigation.PushAsync(new SegundaTela
			{

				BindingContext = hospedagem

			});

		} catch (Exception ex)
		{

			await DisplayAlert("Ops", ex.Message, "OK");

		}


    }

    private void Sobre(object sender, EventArgs e)
    {

		try
		{

			Navigation.PushAsync(new TelaSobre());

		} catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");

		}

    }

    private void DtpckCheckin_DateSelected(object sender, DateChangedEventArgs e)
    {

		DatePicker elemento = sender as DatePicker;

		DateTime DataCheckin = elemento.Date;

		DtpckCheckout.MinimumDate = DataCheckin.AddDays(1);
		DtpckCheckout.MaximumDate = DataCheckin.AddMonths(6);

    }
}