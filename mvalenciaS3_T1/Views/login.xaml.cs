namespace mvalenciaS3_T1.Views;

public partial class login : ContentPage
{
    string usu;
    string pass;
	public login()
	{
		InitializeComponent();
	}
    public login(string usuario,string contrasena)
    {
        InitializeComponent();
        this.usu = usuario;
        this.pass = contrasena;
    }

    private void btn_inicio_Clicked(object sender, EventArgs e)
    {
        if (txt_usuario.Text == usu && txt_contrasena.Text == pass)
        {
            Navigation.PushAsync(new home(txt_usuario.Text));
        }
        else
            DisplayAlert("ERROR", "USUARIO O CONTRASEÑA INCORRECTO", "OK");
    }

    private void btn_crear_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new registrar());
    }
}