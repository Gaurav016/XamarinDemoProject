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
    public partial class DemoDatePickerComponent : ContentView
    {
        public DemoDatePickerComponent()
        {
            InitializeComponent();
        }

        #region DemoLabel
        public static readonly BindableProperty demoLabel = BindableProperty.Create("DemoLabel", typeof(string), typeof(DemoDatePickerComponent), "", propertyChanged: OnLabelChanged);

        public string DemoLabel
        {
            get { return (string)GetValue(demoLabel); }
            set { SetValue(demoLabel, value); }
        }

        static void OnLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoDatePickerComponent)bindable).OndatelablChanged((string)oldValue, (string)newValue);
        }

         void OndatelablChanged(string oldValue, string newValue)
        {
            headlabel.Text = newValue;
        }
        #endregion

        #region DemoDatePicker
        public static readonly BindableProperty DemoDatePickerProperty = BindableProperty.Create("DemoEntry", typeof(System.DateTime), typeof(DemoDatePickerComponent), System.DateTime.Now, propertyChanged: OnDatePickerChanged);

        public System.DateTime DemoDatePicker
        {
            get { return (System.DateTime)GetValue(DemoDatePickerProperty); }
            set { SetValue(DemoDatePickerProperty, value); }
        }

        static void OnDatePickerChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoDatePickerComponent)bindable).OndatePickerChanged((System.DateTime)oldValue, (System.DateTime)newValue);
        }

        void OndatePickerChanged(System.DateTime oldValue, System.DateTime newValue)
        {
            datepicker.Date= newValue;
        }
        #endregion

        #region ErrorLineLabel
        public static readonly BindableProperty ErrorlineLabel = BindableProperty.Create("ErrorLineLabel", typeof(string), typeof(DemoDatePickerComponent), "", propertyChanged: OnErrorLabelChanged);

        public string ErrorLineLabel
        {
            get { return (string)GetValue(ErrorlineLabel); }
            set { SetValue(ErrorlineLabel, value); }
        }

        static void OnErrorLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoDatePickerComponent)bindable).OnerrorlablChanged((string)oldValue, (string)newValue);
        }

        void OnerrorlablChanged(string oldValue, string newValue)
        {
            errorline.Text = newValue;
        }
        #endregion
    }
}