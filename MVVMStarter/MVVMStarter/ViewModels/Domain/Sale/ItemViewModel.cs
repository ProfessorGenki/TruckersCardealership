using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.Base;
using SaleClass = MVVMStarter.Models.Domain.Sale.Sale;
using CarClass = MVVMStarter.Models.Domain.Car.Car;
using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;
using SalespersonClass = MVVMStarter.Models.Domain.Salesperson.Salesperson;
using System;
using MVVMStarter.Models.Domain.Sale;

namespace MVVMStarter.ViewModels.Domain.Sale

{

    public class ItemViewModel : ItemViewModelBase<SaleClass>
    {
        public ItemViewModel(SaleClass obj) : base(obj)
        {
        }

        public string DescriptionCar
        {
            get { return GetCar() == null ? string.Empty : GetCar().Licenseplate; }
        }


        public string DescriptionCustomer
        {
            get { return GetCustomer() == null ? string.Empty : "Bought by " + GetCustomer().Name; }
        }



        public string DescriptionSalesperson
        {
            get { return GetSalesperson() == null ? string.Empty : "Sold by " + GetSalesperson().Name; }
        }

        public override int FontSize
        {
            get { return 18; }
        }

        #region Methods
        private CarClass GetCar()
        {
            return ObjectProvider.CarCatalog.Read(DomainObject.CarKey);
        }

        private CustomerClass GetCustomer()
        {
            return ObjectProvider.CustomerCatalog.Read(DomainObject.CustomerKey);
        }

        private SalespersonClass GetSalesperson()
        {
            return ObjectProvider.SalespersonCatalog.Read(DomainObject.SalespersonKey);
        }
        #endregion
    }

}