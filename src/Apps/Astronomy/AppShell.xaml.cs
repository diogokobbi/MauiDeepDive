namespace Astronomy;
using Pages;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
    }
}
