using MVVMStarter.ViewModels.Base;
using SaleClass = MVVMStarter.Models.Domain.Sale.Sale;

namespace MVVMStarter.ViewModels.Domain.Sale
{
    public class ViewModelFactory : ViewModelFactoryBase<SaleClass>
    {
        public override DetailsViewModelBase<SaleClass> CreateDetailsViewModel(SaleClass obj)
        {
            return new DetailsViewModel(obj);
        }

        public override ItemViewModelBase<SaleClass> CreateItemViewModel(SaleClass obj)
        {
            return new ItemViewModel(obj);
        }

        public override MasterViewModelBase<SaleClass> CreateMasterViewModel()
        {
            return new MasterViewModel();
        }
    }
}