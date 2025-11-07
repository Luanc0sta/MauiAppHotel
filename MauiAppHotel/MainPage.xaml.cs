namespace MauiAppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnServicosClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Serviços");
    }

    private async void OnReservasClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Reservas");
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Sobre");
    }
}

