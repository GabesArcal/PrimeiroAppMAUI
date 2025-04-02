namespace MauiApp1;

public partial class VerticalHorizantal : ContentPage
{
	public VerticalHorizantal()
	{
		InitializeComponent();
	}

    private void Comprar_Clicked(object sender, EventArgs e)
    {
		LabelComprar.IsVisible = true;
    }
}