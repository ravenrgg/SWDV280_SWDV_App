using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CWIApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PWPortalPage : ContentPage
    {

        public PWPortalPage()
        {
            InitializeComponent();

            Title = "SWDV Forms and Documents";

        }
        
         void OnToolbarItemHomeClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new LandingPage());

        }
        
        void OnToolbarItemEventsClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new EventPage());

        }

        void OnToolbarItemFormsClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new PWPortalPage());

        }

        void OnToolbarItemProjectClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new ProjectPage());

        }

        void OnToolbarItemEmailClicked(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new EmailFormPage());

        }


        public void OnLabelOverviewClicked(object sender, EventArgs args)
        {
            
            this.Navigation.PushAsync(new Forms.CourseOverview());
        }

        public void OnLabelInternshipClicked(object sender, EventArgs args)
        {
            
            this.Navigation.PushAsync(new Forms.InternshipForm());
        }

        public void OnLabelInternAFClicked(object sender, EventArgs args)
        {
           
            this.Navigation.PushAsync(new Forms.InternAF());
        }

        public void OnLabelInternTSClicked(object sender, EventArgs args)
        {
            
            this.Navigation.PushAsync(new Forms.InternTS());
        }
    }
}

