using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called DetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Customer
{
    public class DetailsViewModel : DetailsViewModelBase<CustomerClass>
    {
        #region Validering
        // Vi kigger ikke på validering af de informationer vi får endnu. 

        //    // Template for validated property (may throw ValidationException) 
        //    public string MyValidatedProperty
        //    {
        //        get { return DomainObject.MyValidatedProperty; }
        //        set
        //        {
        //            var orgValue = DomainObject.MyValidatedProperty;
        //            try
        //            {
        //                DomainObject.MyValidatedProperty = value;
        //            }
        //            catch (ValidationException e)
        //            {
        //                PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
        //            }
        //            OnPropertyChanged();
        //        }
        //    }

        //    // Template for non-validated property
        //    public string MyNonValidatedProperty
        //    {
        //        get { return DomainObject.MyNonValidatedProperty; }
        //        set
        //        {
        //            DomainObject.MyNonValidatedProperty = value;
        //            OnPropertyChanged();
        //        }
        //    }

        public DetailsViewModel(CustomerClass obj) : base(obj)
        {
        }
        #endregion

        #region Propperties
        public string Name
        {
            get { return DomainObject.Name; }
            set { DomainObject.Name = value; OnPropertyChanged(); }
        }
        public string Adress
        {
            get { return DomainObject.Adress; }
            set { DomainObject.Adress = value; OnPropertyChanged(); }
        }
        public int Phonenumber
        {
            get { return DomainObject.Phonenumber; }
            set { DomainObject.Phonenumber = value; OnPropertyChanged(); }
        }
        public string Email
        {
            get { return DomainObject.Email; }
            set { DomainObject.Email = value; OnPropertyChanged(); }
        }
        public string ID
        {
            get { return DomainObject.ID; }
            set { DomainObject.ID = value; OnPropertyChanged(); }
        }
        #endregion
    }
}