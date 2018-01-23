using System.Collections;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DemoProject.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoPickerComponent : ContentView
    {
        public DemoPickerComponent()
        {
            InitializeComponent();
            picker.SelectedIndexChanged += Picker_SelectedIndexChanged;
        }

        private void Picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedText = picker.SelectedItem.ToString();
        }

        #region DemoLabel
        public static readonly BindableProperty demoLabel = BindableProperty.Create("DemoLabel", typeof(string), typeof(DemoPickerComponent), "", propertyChanged: OnLabelChanged);

        public string DemoLabel
        {
            get { return (string)GetValue(demoLabel); }
            set { SetValue(demoLabel, value); }
        }

        static void OnLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoPickerComponent)bindable).OnlablChanged((string)oldValue, (string)newValue);
        }

        void OnlablChanged(string oldValue, string newValue)
        {
            headlabel.Text = newValue;
        }
        #endregion

        #region DemoPicker
        public static readonly BindableProperty DemoPickerProperty = BindableProperty.Create("DemoPicker", typeof(IEnumerable), typeof(DemoPickerComponent), default(IEnumerable), propertyChanged: OnPickerChanged);

        public IEnumerable DemoPicker
        {
            get { return (IEnumerable)GetValue(DemoPickerProperty); }
            set { SetValue(DemoPickerProperty, value); }
        }

        static void OnPickerChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoPickerComponent)bindable).OnpickerChanged((IEnumerable)oldValue, (IEnumerable)newValue);
        }

        void OnpickerChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            
           
            foreach (var item in newValue)
            {
                picker.Items.Add(item as string);
            }
        }
        #endregion

        #region ErrorLineLabel
        public static readonly BindableProperty ErrorlineLabel = BindableProperty.Create("ErrorLineLabel", typeof(string), typeof(DemoPickerComponent), "", propertyChanged: OnErrorLabelChanged);

        public string ErrorLineLabel
        {
            get { return (string)GetValue(ErrorlineLabel); }
            set { SetValue(ErrorlineLabel, value); }
        }

        static void OnErrorLabelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoPickerComponent)bindable).OnerrorlablChanged((string)oldValue, (string)newValue);
        }

        void OnerrorlablChanged(string oldValue, string newValue)
        {
            errorline.Text = newValue;
        }
        #endregion

        #region SelectedText
        public static readonly BindableProperty SelectedTextProperty = BindableProperty.Create("SelectedText", typeof(string),typeof(DemoPickerComponent),"",BindingMode.TwoWay,propertyChanged:SelectedTextChanged);

        public string SelectedText
        {
            get { return (string)GetValue(DemoPickerProperty); }
            set { SetValue(DemoPickerProperty, value); }
        }

        static void SelectedTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((DemoPickerComponent)bindable).SelectedtextChanged((string)oldValue, (string)newValue);
        }

        void SelectedtextChanged(string oldValue, string newValue)
        {
            picker.SelectedItem = newValue;
        }
        #endregion
    }
}