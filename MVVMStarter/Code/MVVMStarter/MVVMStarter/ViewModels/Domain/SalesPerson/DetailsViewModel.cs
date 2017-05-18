using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using SalespersonClass = MVVMStarter.Models.Domain.Salesperson.Salesperson;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called DetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Salesperson
{
    public class DetailsViewModel : DetailsViewModelBase<SalespersonClass>
    {
        //// Template for validated property (may throw ValidationException) 
        //public string ValidatedName
        //{
        //    get { return DomainObject.Name; }
        //    set
        //    {
        //        var orgValue = DomainObject.Name;
        //        try
        //        {
        //            DomainObject.Name = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedName = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}
        //public string ValidatedEmail
        //{
        //    get { return DomainObject.Email; }
        //    set
        //    {
        //        var orgValue = DomainObject.Email;
        //        try
        //        {
        //            DomainObject.Email = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedEmail = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //public string ValidatedPhone
        //{
        //    get { return DomainObject.Phone; }
        //    set
        //    {
        //        var orgValue = DomainObject.Phone;
        //        try
        //        {
        //            DomainObject.Phone = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedPhone = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}
        //public string ValidatedAddress
        //{
        //    get { return DomainObject.Address; }
        //    set
        //    {
        //        var orgValue = DomainObject.Address;
        //        try
        //        {
        //            DomainObject.Address = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedAddress = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //public double ValidatedCommission
        //{
        //    get { return DomainObject.Commision; }
        //    set
        //    {
        //        var orgValue = DomainObject.Commision;
        //        try
        //        {
        //            DomainObject.Commision = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedCommission = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        //public int ValidatedSalespersonID
        //{
        //    get { return DomainObject.SalespersonID; }
        //    set
        //    {
        //        var orgValue = DomainObject.SalespersonID;
        //        try
        //        {
        //            DomainObject.SalespersonID = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { ValidatedSalespersonID = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}


        //// Template for non-validated property
        //public string MyNonValidatedProperty
        //{
        //    get { return DomainObject.MyNonValidatedProperty; }
        //    set
        //    {
        //        DomainObject.MyNonValidatedProperty = value;
        //        OnPropertyChanged();
        //    }
        //}

        public string Name
        {
            get { return DomainObject.Name; }
            set
            {
                DomainObject.Name = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return DomainObject.Email; }
            set
            {
                DomainObject.Email = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return DomainObject.Phone; }
            set
            {
                DomainObject.Phone = value;
                OnPropertyChanged();
            }

        }

        public string Address
        {
            get { return DomainObject.Address; }
            set
            {
                DomainObject.Address = value;
                OnPropertyChanged();
            }
        }
        public int SalespersonID
        {
            get { return DomainObject.SalespersonID; }
            set
            {
                DomainObject.SalespersonID = value;
                OnPropertyChanged();
            }
        }
        public double Commision
        {
            get
            {
                return DomainObject.Commision;
                
            }
        }

        public DetailsViewModel(SalespersonClass obj) : base(obj)
        {
        }
    }
}
