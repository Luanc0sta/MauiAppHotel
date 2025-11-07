namespace MauiAppHotel.Views;

public partial class ReservasPage : ContentPage
{
    public ReservasPage()
    {
        InitializeComponent();
    }

    private void OnConfirmarReserva(object sender, EventArgs e)
    {
        lblConfirmacao.Text = "✅ Reserva confirmada com sucesso!";
    }
}
