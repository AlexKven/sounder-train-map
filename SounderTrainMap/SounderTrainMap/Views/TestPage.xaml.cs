using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SounderTrainMap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        int curNum = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            curNum++;
            NumberBox.Text = curNum.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            curNum--;
            NumberBox.Text = curNum.ToString();
        }
    }
}