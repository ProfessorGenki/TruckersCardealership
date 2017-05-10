using MVVMStarter.Validators.App;
using MVVMStarter.ViewModels.Base;
using CarClass = MVVMStarter.Models.Domain.Car.Car;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called DetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Car
{
    public class DetailsViewModel : DetailsViewModelBase<CarClass>
    {
        //// Template for validated property (may throw ValidationException) 
        //public string MyValidatedProperty
        //{
        //    get { return DomainObject.MyValidatedProperty; }
        //    set
        //    {
        //        var orgValue = DomainObject.MyValidatedProperty;
        //        try
        //        {
        //            DomainObject.MyValidatedProperty = value;
        //        }
        //        catch (ValidationException e)
        //        {
        //            PresentValidationError(e.Message, () => { MyValidatedProperty = orgValue; });
        //        }
        //        OnPropertyChanged();
        //    }
        //}

        // Template for non-validated property


        public string Brand
        {
            get { return DomainObject.Brand; }
            set
            {
                DomainObject.Brand = value;
                OnPropertyChanged();
            }
        }




        public int ID
        {
            get { return DomainObject.ID; }
            set
            {
                DomainObject.ID = value;
                OnPropertyChanged();
            }
        }

        public string Licenseplate
        {
            get { return DomainObject.Licenseplate; }
            set
            {
                DomainObject.Licenseplate = value;
                OnPropertyChanged();
            }
        }
        public string Model
        {
            get { return DomainObject.Model; }
            set
            {
                DomainObject.Model = value;
                OnPropertyChanged();
            }
        }
        public int Year
        {
            get { return DomainObject.Year; }
            set
            {
                DomainObject.Year = value;
                OnPropertyChanged();
            }
        }

        public int Kilometers
        {
            get { return DomainObject.Kilometers; }
            set
            {
                DomainObject.Kilometers = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get { return DomainObject.Price; }
            set
            {
                DomainObject.Price = value;
                OnPropertyChanged();
            }
        }

        public string Color
        {
            get { return DomainObject.Color; }
            set
            {
                DomainObject.Color = value;
                OnPropertyChanged();
            }
        }

        public string Condition
        {
            get { return DomainObject.Condition; }
            set
            {
                DomainObject.Condition = value;
                OnPropertyChanged();
            }
        }
        public DetailsViewModel(CarClass obj) : base(obj)
        {
        }
    }
}
