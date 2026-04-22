namespace Practica02DDAMAmo1015.Views;

public partial class ConfiguracionPage : ContentPage
{
    public ConfiguracionPage()
    {
        InitializeComponent();
    }

    private void OnTextSizeChanged(object sender, ValueChangedEventArgs e)
    {
        Application.Current.Resources["GlobalFontSize"] = e.NewValue;
    }

    private void OnColorChanged(object sender, EventArgs e)
    {
        string color = ColorPicker.SelectedItem as string;

        Application.Current.Resources["GlobalFontColor"] = color switch
        {
            "Negro" => Colors.Black,
            "Rojo" => Colors.Red,
            "Azul" => Colors.Blue,
            "Verde" => Colors.Green,
            _ => Colors.Black
        };
    }

    private void OnFontChanged(object sender, EventArgs e)
    {
        string font = FontPicker.SelectedItem as string;

        Application.Current.Resources["GlobalFontFamily"] = font switch
        {
            "Sans" => "sans-serif",
            "Serif" => "serif",
            "Monospace" => "monospace",
            _ => "sans-serif"
        };
    }
}
