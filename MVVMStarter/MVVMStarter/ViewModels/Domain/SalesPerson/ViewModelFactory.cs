using MVVMStarter.ViewModels.Base;
using SalespersonClass = MVVMStarter.Models.Domain.Salesperson.Salesperson;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called ViewModelFactory.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Salesperson
{
    public class ViewModelFactory : ViewModelFactoryBase<SalespersonClass>
    {
        public override DetailsViewModelBase<SalespersonClass> CreateDetailsViewModel(SalespersonClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<SalespersonClass> CreateItemViewModel(SalespersonClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<SalespersonClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
