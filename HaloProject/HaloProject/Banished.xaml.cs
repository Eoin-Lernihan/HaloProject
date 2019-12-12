using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HaloProject
{
    public partial class Banished : ContentPage
	{
        string _fileName;
        public Banished ()
		{
			InitializeComponent ();
            _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IDName.txt");
            string name = File.ReadAllText(_fileName);
            IDNum.Text = "Angent " + name;
        }
	}
}