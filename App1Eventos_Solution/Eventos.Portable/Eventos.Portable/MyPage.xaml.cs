using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Eventos.Portable
{
    public partial class MyPage : ContentPage
    {
        public string MainText { get; set; }

        public MyPage()
        {
            this.BindingContext = this;
            MainText = "I say hey! What's going on?";
            InitializeComponent();
        }
    }
}