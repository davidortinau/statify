using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Statify
{
    public partial class MainPage : ContentPage
    {
        string curState = "Red";

        public MainPage()
        {
            InitializeComponent();
            SetState(curState);
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            curState = (curState == "Blue") ? "Red" : "Blue";
            SetState(curState);
        }

        private void SetState(string visualState)
        {
            VisualStateManager.GoToState(this, visualState);
            VisualStateManager.GoToState(MyLabel, visualState);
        }
    }
}
