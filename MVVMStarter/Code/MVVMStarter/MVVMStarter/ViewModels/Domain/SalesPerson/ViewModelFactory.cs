using MVVMStarter.ViewModels.Base;
using SalesPersonClass = MVVMStarter.Models.Domain.SalesPerson.SalesPerson;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called ViewModelFactory.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.SalesPerson
{
    public class ViewModelFactory : ViewModelFactoryBase<SalesPersonClass>
    {
        public override DetailsViewModelBase<SalesPersonClass> CreateDetailsViewModel(SalesPersonClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<SalesPersonClass> CreateItemViewModel(SalesPersonClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<SalesPersonClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
