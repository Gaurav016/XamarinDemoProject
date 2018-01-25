using DemoProject.Model;
using DemoProject.View;
using DemoProject.View.MasterPage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoProject.ViewModel
{
   public class ProfileDataViewModel: PropertyNotifier
    {
        private static string jsonmodel;

        private static List<ProfileData> _setprofileDataList;

        private ObservableCollection<ProfileData> _getprofileDataList;
        public ObservableCollection<ProfileData> GetprofileDataList
        {
            get { return _getprofileDataList; }
            set { _getprofileDataList = value; }
        }

        public List<string> nationalitylist { get; set; }
   
        private static ProfileData _profiledata;
        public ProfileData profileData
        {
            get { return _profiledata; }
            set { _profiledata = value; }
        }
       
        public ICommand SetDataCommand { get; private set; }
        public ICommand ShowDataCommand { get; private set; }

        public ProfileDataViewModel()
        {           
            SetDataCommand = new Command(SetDataModel); // firing method from XAML directly in View Model
            ShowDataCommand = new Command(ShowDataModel);
        }

        public ProfileDataViewModel(INavigation inav) : this() // Using Dependency injection to pass the control of navigation from View to View Model
        {
            NavigationService = inav;
            nationalitylist = new List<string>() { "India", "USA", "UK" };
            _profiledata = new ProfileData();
            _setprofileDataList = new List<ProfileData>() {
                new ProfileData() {Name="Gaurav", Gender="Male", MaritalStatus="Married",Nationality="Indian" },
                new ProfileData() {Name="Akash",Gender="Male", MaritalStatus="UnMarried",Nationality="Indian" } };
            _getprofileDataList = new ObservableCollection<ProfileData>();
        }

        void ShowDataModel()
        {
            NavigationService.PushAsync(new DetailDataPage());
            OnPropertyChanged("profileData");
        }

        void SetDataModel() // Method fired using Command 
        {
            _setprofileDataList.Add(profileData);
            jsonmodel = JsonConvert.SerializeObject(_setprofileDataList);
            NavigationService.PushAsync(new Root());            
        }

        public void GetDataModel()
        {
            try
            {
                if (!string.IsNullOrEmpty(jsonmodel))
                {
                    _getprofileDataList = JsonConvert.DeserializeObject<ObservableCollection<ProfileData>>(jsonmodel);
                }
            }
            catch(Exception ex)
            {

            }
            OnPropertyChanged("GetprofileDataList");
        }
    }
}
