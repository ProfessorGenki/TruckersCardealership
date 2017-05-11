using MVVMStarter.Models.App;

using MVVMStarter.ViewModels.Base;

using SaleClass = MVVMStarter.Models.Domain.Sale.Sale;

using CarClass = MVVMStarter.Models.Domain.Car.Car;

using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;

using EmployeeClass = MVVMStarter.Models.Domain.Employee.Employee;



namespace MVVMStarter.ViewModels.Domain.Sale

{

    public class ItemViewModel : ItemViewModelBase<SaleClass>

    {

        public string DescriptionCar

        {

            get { return GetCar() == null ? string.Empty : GetCar().LicensePlate; }

        }



        public string DescriptionCustomer

        {

            get { return GetCustomer() == null ? string.Empty : "Bought by " + GetCustomer().FullName; }

        }



        public string DescriptionEmployee

        {

            get { return GetEmployee() == null ? string.Empty : "Sold by " + GetEmployee().FullName; }

        }



        public override int FontSize

        {

            get { return 14; }

        }



        public override string ImageSource

        {

            get
            {
                return GetCar() == null ?

                  string.Empty :

                  ObjectProvider.ImageCatalog.ReadSafe(GetCar().ImageKey).Source;
            }

        }



        private CarClass GetCar()

        {

            return ObjectProvider.CarCatalog.Read(DomainObject.CarKey);

        }



        private CustomerClass GetCustomer()

        {

            return ObjectProvider.CustomerCatalog.Read(DomainObject.CustomerKey);

        }



        private EmployeeClass GetEmployee()

        {

            return ObjectProvider.EmployeeCatalog.Read(DomainObject.EmployeeKey);

        }



        public ItemViewModel(SaleClass obj) : base(obj)

        {

        }

    }

}