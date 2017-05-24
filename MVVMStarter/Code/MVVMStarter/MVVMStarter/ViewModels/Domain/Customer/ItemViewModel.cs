using MVVMStarter.ViewModels.Base;
using System;
using CustomerClass = MVVMStarter.Models.Domain.Customer.Customer;

/* Vi sætter "MVVMStarter.Models.Domain.Customer.Customer;" (som er hvor vores customer class er placeret) den sætter den til "CustomerClass" 
 * så hvis vi skal peje hen til classen, skal vi skrive mindre*/


namespace MVVMStarter.ViewModels.Domain.Customer
{
    public class ItemViewModel : ItemViewModelBase<CustomerClass>
    {
        /*Override any of the below properties, if you wish to
        replace the default implementation with your own
        (the below examples contain the default implementation)*/


        public override string Description
        {
            get { return DomainObject.Name + " " + DomainObject.ID; }
        }

        public override int FontSize
        {
            get { return 18; }
        }

        //public override string ImageSource
        //{
        //    get { return String.Empty; } //hvorfor virker det med using.System; og hvad sker der?
        //}

        public override int ImageSize
        {
            get { return 80; }
        }

        public override bool ImageIsVisible
        {
            get { return true; }
        }

        public ItemViewModel(CustomerClass obj) : base(obj)
        {
        }
    }
}
