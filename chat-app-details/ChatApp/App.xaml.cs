using ChatApp.Models;
using ChatApp.ViewModels;
using ChatApp.Views;
using System.Runtime.Intrinsics.X86;

namespace ChatApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        User user = new User
        {
            Name = "Alaya Cordova",
            Image = "emoji1.png",
            Color = Color.FromArgb("#FFE0EC")
        };
        var message = new Message
        {
            Sender = user,
            Time = "18:32",
            Text = "Hey there! What\'s up? Is everything ok?",
        };

        var vm = new DetailViewModel();
        vm.InitializeAsync(message).Wait();
        var detailView = new DetailView();
        detailView.BindingContext = vm;
        MainPage = new NavigationPage(detailView);
	}
}