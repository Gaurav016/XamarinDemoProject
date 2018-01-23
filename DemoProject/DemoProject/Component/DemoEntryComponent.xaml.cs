using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoEntryComponent : ContentView
    {
        public DemoEntryComponent()
        {
            InitializeComponent();
            entry.TextChanged += Entry_TextChanged;
            headlabel.IsVisible = false;
            errorline.IsVisible = false;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 0)
            {
                headlabel.IsVisible = true;
            }
            else
            {
                headlabel.IsVisible = false;
            }
            DemoEntry = e.NewTextValue;
        }

        #region DemoLabel
        public static readonly BindableProperty demoLabel = BindableProperty.Create("DemoLabel",typeof(string),typeof(DemoEntryComponent),"",propertyChanged:OnLabelChanged);

        public string DemoLabel
        {
            get { return (string)GetValue(demoLabel); }
            set { SetValue(demoLabel, value); }
        }

        static void OnLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoEntryComponent)bindable).OnlablChanged((string)oldValue, (string)newValue);
        }

        void OnlablChanged(string oldValue, string newValue)
        {
            headlabel.Text = newValue;
        }
        #endregion

        #region DemoEntry
        public static readonly BindableProperty DemoEntryProperty = BindableProperty.Create("DemoEntry", typeof(string), typeof(DemoEntryComponent),"",propertyChanged:OnEntryChanged);

        public string DemoEntry
        {
            get { return (string)GetValue(DemoEntryProperty); }
            set { SetValue(DemoEntryProperty, value); }
        }

        static void OnEntryChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoEntryComponent)bindable).OnentryChanged((string)oldValue, (string)newValue);
        }

        void OnentryChanged(string oldValue, string newValue)
        {
            entry.Text = newValue;
        }
        #endregion

        #region ErrorLineLabel
        public static readonly BindableProperty ErrorlineLabel = BindableProperty.Create("ErrorLineLabel", typeof(string), typeof(DemoEntryComponent), "", propertyChanged: OnErrorLabelChanged);

        public string ErrorLineLabel
        {
            get { return (string)GetValue(ErrorlineLabel); }
            set { SetValue(ErrorlineLabel, value); }
        }

        static void OnErrorLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoEntryComponent)bindable).OnerrorlablChanged((string)oldValue, (string)newValue);
        }

        void OnerrorlablChanged(string oldValue, string newValue)
        {
            errorline.Text = newValue;
        }
        #endregion
    }
}