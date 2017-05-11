using System;
using System.Collections.ObjectModel;
using MVVMStarter.Models.App;
using MVVMStarter.ViewModels.Base;
using MVVMStarter.ViewModels.Domain.Salesperson;
using SaleClass = MVVMStarter.Models.Domain.Sale.Sale;

namespace MVVMStarter.ViewModels.Domain.Sale
{
    public class DetailsViewModel : DetailsViewModelBase<SaleClass>
    {
        private ObservableCollection<Car.ItemViewModel> _observableCollectionCars;
        private ObservableCollection<Customer.ItemViewModel> _observableCollectionCustomers;
        private ObservableCollection<Salesperson.ItemViewModel> _observableCollectionSalesperson;

        public DateTimeOffset Date
        {
            get { return DomainObject.SalesDate; }
            set
            {
                DomainObject.SalesDate = value;
                OnPropertyChanged();
            }
        }

        //public int Price
        //{
        //    get { return DomainObject.Price; }
        //    set
        //    {
        //        DomainObject.Price = value;
        //        OnPropertyChanged();
        //    }
        //}

        public ObservableCollection<Car.ItemViewModel> CollectionCars
        {
            get { return _observableCollectionCars; }
        }

        public ObservableCollection<Customer.ItemViewModel> CollectionCustomers
        {
            get { return _observableCollectionCustomers; }
        }

        public ObservableCollection<Salesperson.ItemViewModel> CollectionSalesPerson
        {
            get { return _observableCollectionSalesperson; }
        }

        public Car.ItemViewModel SelectedCar
        {
            get { return GetCarItemViewModel(DomainObject.CarKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.CarKey = value.DomainObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Customer.ItemViewModel SelectedCustomer
        {
            get { return GetCustomerItemViewModel(DomainObject.CustomerKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.CustomerKey = value.DomainObject.Key;
                }
                OnPropertyChanged();
            }
        }

        public Salesperson.ItemViewModel SelectedSalesperson
        {
            get { return GetSalesPersonItemViewModel(DomainObject.SalespersonKey); }
            set
            {
                if (value != null)
                {
                    DomainObject.SalespersoneKey = value.DomainObject.Key;
                }
                OnPropertyChanged();
            }
        }

        private Car.ItemViewModel GetCarItemViewModel(int key)
        {
            foreach (var carItemViewModel in _observableCollectionCars)
            {
                if (carItemViewModel.DomainObject.Key == key)
                {
                    return carItemViewModel;
                }
            }

            return null;
        }

        private Customer.ItemViewModel GetCustomerItemViewModel(int key)
        {
            foreach (var customerItemViewModel in _observableCollectionCustomers)
            {
                if (customerItemViewModel.DomainObject.Key == key)
                {
                    return customerItemViewModel;
                }
            }

            return null;
        }

        private Salesperson.ItemViewModel GetSalesPersonItemViewModel(int key)
        {
            foreach (var SalesPersonItemViewModel in _observableCollectionSalespersons)
            {
                if (SalesPersonItemViewModel.DomainObject.Key == key)
                {
                    return SalesPersonItemViewModel;
                }
            }

            return null;
        }

        public DetailsViewModel(SaleClass obj) : base(obj)
        {
            _observableCollectionCars = new ObservableCollection<Car.ItemViewModel>();
            _observableCollectionCustomers = new ObservableCollection<Customer.ItemViewModel>();
            _observableCollectionSalespersons = new ObservableCollection<Salesperson.ItemViewModel>();

            foreach (var car in ObjectProvider.Carcatalog.All)
            {
                _observableCollectionCars.Add(new Car.ItemViewModel(car));
            }

            foreach (var customer in ObjectProvider.CustomerCatalog.All)
            {
                _observableCollectionCustomers.Add(new Customer.ItemViewModel(customer));
            }

            foreach (var employee in ObjectProvider.SPCatalog.All)
            {
                _observableCollectionSalespersons.Add(new Salesperson.ItemViewModel(employee));
            }
        }
    }
}
