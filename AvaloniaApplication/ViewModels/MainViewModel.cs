using AvaloniaApplication.Domain;
using AvaloniaApplication.Views;

namespace AvaloniaApplication.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    private GameView gameView;
    private ComponentsView componentsView;
    private ServiceProvider serviceProvider;
    public GameView GameView { get => gameView; set { gameView = value; } }
    public ComponentsView ComponentsView { get => componentsView; set { componentsView = value; } }
    public MainViewModel(ServiceProvider serviceProvider)
    {
        gameView = new GameView() { DataContext = new GameViewModel(serviceProvider) };
        componentsView = new ComponentsView() { DataContext = new ComponentsViewModel(serviceProvider) };
    }
}
