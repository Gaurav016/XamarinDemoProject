using DemoProject.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoProject.ViewModel
{
   public class ProfileDataViewModel: PropertyNotifier
    {
        private static List<string> jsonmodel = new List<string>();
        public List<string> nationalitylist { get; set; }
   
        public ProfileData profileData { get; set; }
        public ICommand GetDataCommand { get; private set; }
        public ProfileDataViewModel()
        {
            profileData = new ProfileData();
            GetDataCommand = new Command(GetDataModel);
            nationalitylist = new List<string>() { "India", "USA", "UK" };
        }

        void GetDataModel()
        {
            string data = JsonConvert.SerializeObject(profileData);
            jsonmodel.Add(data);
        }
    }
}
