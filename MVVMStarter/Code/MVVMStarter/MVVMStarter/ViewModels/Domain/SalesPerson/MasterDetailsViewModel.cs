using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using SalesPersonClass = MVVMStarter.Models.Domain.SalesPerson.SalesPerson;


namespace MVVMStarter.ViewModels.Domain.SalesPerson
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<SalesPersonClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.SalesPerson.SPCatalog.Instance)
        {
            //// Use the below code as a template for setting up default
            //// behavior for your GUI controls

            //List<string> fixedProperties = new List<string>();
            //// Add names of "fixed" (cannot be changed after creation) properties here
            //fixedProperties.Add(nameof(_REPLACEME_Class.FixedPropertyA));
            //fixedProperties.Add(nameof(_REPLACEME_Class.FixedPropertyB));
            //fixedProperties.Add(nameof(_REPLACEME_Class.FixedPropertyC));

            //List<string> nonFixedKeyProperties = new List<string>();
            //// Add names of "non-fixed" (can be changed after creation) properties here
            //nonFixedKeyProperties.Add(nameof(_REPLACEME_Class.NonFixedPropertyA));
            //nonFixedKeyProperties.Add(nameof(_REPLACEME_Class.NonFixedPropertyB));

            //StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            //StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            //StateManager.AddButtonDefaultStates();

            List<string> fixedProperties = new List<string>();
            // Add names of "fixed" (cannot be changed after creation) properties here
            fixedProperties.Add(nameof(SalesPersonClass.SalespersonID));
            fixedProperties.Add(nameof(SalesPersonClass.Name));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(SalesPersonClass.Address));
            nonFixedKeyProperties.Add(nameof(SalesPersonClass.Commission));
            nonFixedKeyProperties.Add(nameof(SalesPersonClass.Phone));
            nonFixedKeyProperties.Add(nameof(SalesPersonClass.Email));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
