using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabbedwithContentView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbedwithContentView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : Frame
    {
        public MenuView()
        {
            InitializeComponent();
        }
    }
}