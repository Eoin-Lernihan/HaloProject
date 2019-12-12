using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HaloProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home: ContentPage
	{
        //Varibles for the file
        string _fileName;
        public Home()
		{
			InitializeComponent ();

            //Calls the file IDName.txt
            _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IDName.txt");
            CheckForUserName();
        }

        private void CheckForUserName()
        {
            //See if there is already a user name in the file
            string name = File.ReadAllText(_fileName);
            if( name != null)
            {
                EntryUser.Text = name;
            }
        }

        private async void Login(Object sender, EventArgs e)
        {
            //Writes the username to the file
            var entry = new Entry { Placeholder = "Username", MaxLength = 15 };
            string text = EntryUser.Text;
            File.WriteAllText(_fileName, text);
            //Read out the username to the display message
            string name = File.ReadAllText(_fileName);
            await DisplayAlert("Welcome Agent " + name, "Please remember all information is highly classified information", "Continue");
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}