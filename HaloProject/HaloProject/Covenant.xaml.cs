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
    public partial class Covenant : ContentPage
	{
        string _fileName;
        public Covenant ()
		{
            //prints the Agent name to the screen
            InitializeComponent();
            _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IDName.txt");
            string name = File.ReadAllText(_fileName);
            IDNum.Text = "Agent " + name;
        }


    }
}