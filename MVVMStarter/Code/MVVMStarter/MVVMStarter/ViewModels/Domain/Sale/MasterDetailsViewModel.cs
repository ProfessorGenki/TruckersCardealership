using System.Collections.Generic;
using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.Base;
using SaleClass = MVVMStarter.Models.Domain.Sale.Sale;

namespace MVVMStarter.ViewModels.Domain.Sale
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<SaleClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), ObjectProvider.SaleCatalog)
        {
            List<string> fixedProperties = new List<string>();
            fixedProperties.Add("Car");
            fixedProperties.Add("Customer");
            fixedProperties.Add("Salesperson");

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) view properties here
            nonFixedKeyProperties.Add("Date");
            nonFixedKeyProperties.Add("Price");

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}