using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;
/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called MasterDetailsViewModel.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
namespace MVVMStarter.ViewModels.Domain.Customer
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<CustomerClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Customer.Catalog.Instance)
        {
            // use the below code as a template for setting up default
            // behavior for your gui controls

            List<string> fixedproperties = new List<string>();
            // add names of "fixed" (cannot be changed after creation) properties here
            fixedproperties.Add(nameof(CustomerClass.Name));
            fixedproperties.Add(nameof(CustomerClass.ID));

            List<string> nonfixedkeyproperties = new List<string>();
            // add names of "non-fixed" (can be changed after creation) properties here
            nonfixedkeyproperties.Add(nameof(CustomerClass.Adress));
            nonfixedkeyproperties.Add(nameof(CustomerClass.Phonenumber));
            nonfixedkeyproperties.Add(nameof(CustomerClass.Email));

            StateManager.AddFixedPropertiesDefaultStates(fixedproperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonfixedkeyproperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
