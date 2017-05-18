using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;
using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called _REPLACEME_.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain.Car
{
    public class Car : DomainClassBase
    {

        #region InstanceFields
        private string _Licenseplate;
        private string _Brand;
        private string _Model;
        private int _Year;
        private int _Kilometers;
        private int _ID;
        private double _price;
        private string _color;
        private string _condition;
        #endregion

        #region Properties
        public string Licenseplate
        {
            get { return _Licenseplate; }
            set { _Licenseplate = value; }
        }

        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public int Kilometers
        {
            get { return _Kilometers; }
            set { _Kilometers = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
        #endregion

       



        public override void SetDefaultValues()
        {
            _Licenseplate = "(License)";
            _Brand = "(Brand)";
            _Model = "(Model)";
            _Year = 0;
            _Kilometers = 0;
            _ID = 1;
            _price = 0;
            _color = "(Color)";
            _condition = "(condition)";
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}