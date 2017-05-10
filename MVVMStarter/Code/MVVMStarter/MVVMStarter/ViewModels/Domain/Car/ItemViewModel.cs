using MVVMStarter.ViewModels.Base;
using System;
using CarClass = MVVMStarter.Models.Domain.Car.Car;

namespace MVVMStarter.ViewModels.Domain.Car
{
    public class ItemViewModel : ItemViewModelBase<CarClass>
    {
        /*Override any of the below properties, if you wish to
          replace the default implementation with your own
          (the below examples contain the default implementation)*/


        public override string Description
        {
            get { return DomainObject.Licenseplate + " " + DomainObject.Model; }
        }

        public override int FontSize
        {
            get { return 18; }
        }

        public override string ImageSource
        {
            get { return String.Empty; }
        }

        public override int ImageSize
        {
            get { return 80; }
        }

        public override bool ImageIsVisible
        {
            get { return true; }
        }

        public ItemViewModel(CarClass obj) : base(obj)
        {
        }
    }
}
