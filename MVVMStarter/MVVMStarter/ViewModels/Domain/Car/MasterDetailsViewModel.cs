using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using CarClass = MVVMStarter.Models.Domain.Car.Car;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called MasterDetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
namespace MVVMStarter.ViewModels.Domain.Car
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<CarClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Car.Catalog.Instance)
        {


            List<string> fixedproperties = new List<string>();
            // add names of "fixed" (cannot be changed after creation) properties here
            fixedproperties.Add(nameof(CarClass.Licenseplate));
            fixedproperties.Add(nameof(CarClass.ID));


            List<string> nonfixedkeyproperties = new List<string>();
            // add names of "non-fixed" (can be changed after creation) properties here
            nonfixedkeyproperties.Add(nameof(CarClass.Model));
            nonfixedkeyproperties.Add(nameof(CarClass.Kilometers));
            nonfixedkeyproperties.Add(nameof(CarClass.Year));
            nonfixedkeyproperties.Add(nameof(CarClass.Price));
            nonfixedkeyproperties.Add(nameof(CarClass.Color));
            nonfixedkeyproperties.Add(nameof(CarClass.Condition));
            nonfixedkeyproperties.Add(nameof(CarClass.Brand));


            StateManager.AddFixedPropertiesDefaultStates(fixedproperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonfixedkeyproperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
