using MVVMStarter.ViewModels.Base;
using _CarClass = MVVMStarter.Models.Domain.Car.Car;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called ViewModelFactory.cs in your domain folder (under ViewModel/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.ViewModels.Domain.Car
{
    public class ViewModelFactory : ViewModelFactoryBase<_CarClass>
    {
        public override DetailsViewModelBase<_CarClass> CreateDetailsViewModel(_CarClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<_CarClass> CreateItemViewModel(_CarClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<_CarClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}
