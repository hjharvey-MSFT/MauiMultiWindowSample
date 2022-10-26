using System.Diagnostics;

namespace MauiMultiWindowSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += Window_Created;
        window.Activated += Window_Activated;
        window.HandlerChanged += Window_HandlerChanged;
        Debug.WriteLine("Create Window");
        // Manipulate Window object

        return window;
    }

    private void Window_HandlerChanged(object sender, EventArgs e)
    {
        Debug.WriteLine("Window_HandlerChanged");
    }

    private void Window_Activated(object sender, EventArgs e)
    {
        Debug.WriteLine("Window_Activated");
    }

    private void Window_Created(object sender, EventArgs e)
    {
        Debug.WriteLine("Window_Created");
    }
}
