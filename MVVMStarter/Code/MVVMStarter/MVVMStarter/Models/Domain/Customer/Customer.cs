using MVVMStarter.Configuration.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;
using MVVMStarter.Validators.Domain.Customer;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called _REPLACEME_.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain.Customer
{
    public class Customer : DomainClassBase
    {

        #region instancefields 
        private string _name;
        private string _adress;
        private int _phonenumber;
        private string _email;
        private string _ID;
        #endregion

        #region Propperties
        // set propperties bliver ikke pt brugt. 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        public int Phonenumber
        {
            get { return _phonenumber; }    
            set
            {
                ValidationHandler.ThrowOnInvalid<int>(ValidationHandler.ValidatePhonenumber, value);
                _phonenumber = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        #endregion


        public override void SetDefaultValues()
        {
            _name = "Name";
            _adress = "kildevej 19, 4000 Roskilde";
            _phonenumber = 53535353;
            _email = "Email@";
            ID = "CustomerID";
        }

    }
}