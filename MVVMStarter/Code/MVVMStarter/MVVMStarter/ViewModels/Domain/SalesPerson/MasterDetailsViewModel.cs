using System.Collections.Generic;
using MVVMStarter.ViewModels.App;
using MVVMStarter.ViewModels.Base;
using SalespersonClass = MVVMStarter.Models.Domain.Salesperson.Salesperson;


namespace MVVMStarter.ViewModels.Domain.Salesperson
{
    public class MasterDetailsViewModel : MasterDetailsViewModelBase<SalespersonClass>
    {
        public MasterDetailsViewModel()
            : base(new ViewModelFactory(), Models.Domain.Salesperson.Catalog.Instance)
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
            fixedProperties.Add(nameof(SalespersonClass.SalespersonID));
            fixedProperties.Add(nameof(SalespersonClass.Name));

            List<string> nonFixedKeyProperties = new List<string>();
            // Add names of "non-fixed" (can be changed after creation) properties here
            nonFixedKeyProperties.Add(nameof(SalespersonClass.Address));
            nonFixedKeyProperties.Add(nameof(SalespersonClass.Commision));
            nonFixedKeyProperties.Add(nameof(SalespersonClass.Phone));
            nonFixedKeyProperties.Add(nameof(SalespersonClass.Email));

            StateManager.AddFixedPropertiesDefaultStates(fixedProperties);
            StateManager.AddNonFixedPropertiesDefaultStates(nonFixedKeyProperties);
            StateManager.AddButtonDefaultStates();
        }
    }
}
