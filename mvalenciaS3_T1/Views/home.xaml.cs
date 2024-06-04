namespace mvalenciaS3_T1.Views;

public partial class home : ContentPage
{
	public home(string nombre)
	{
		InitializeComponent();
		lbl_nombre.Text = nombre;
	}
}