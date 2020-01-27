using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TabbedPageBindingPrismException.Models;
using TabbedPageBindingPrismException.Views;
using TabbedPageBindingPrismException.ViewModels;

namespace TabbedPageBindingPrismException.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class TabbedDetailPage : TabbedPage
    {
        public TabbedDetailPage()
        {
            InitializeComponent();
        }
    }
}