using MVVMStarter.ViewModels.Base;
using MVVMStarter.ViewModels.Domain.Customer;
using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;


/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called ViewModelFactory.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Customer
{
    public class ViewModelFactory : ViewModelFactoryBase<CustomerClass>
    {
        public override DetailsViewModelBase<CustomerClass> CreateDetailsViewModel(CustomerClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<CustomerClass> CreateItemViewModel(CustomerClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<CustomerClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
