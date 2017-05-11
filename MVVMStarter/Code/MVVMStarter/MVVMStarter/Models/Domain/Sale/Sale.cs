using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;
using System;

namespace MVVMStarter.Models.Domain.Sale
{
    public class Sale : DomainClassBase
    {
        private int _carKey;
        private int _customerKey;
        private int _employeeKey;

        private DateTimeOffset _salesDate;
        private int _saleID;

        public Sale()
        {
            SetDefaultValues();
        }


        public int CarKey
        {
            get { return _carKey; }
            set { _carKey = value; }
        }

        public int CustomerKey
        {
            get { return _customerKey; }
            set { _customerKey = value; }
        }

        public int SalespersoneKey
        {
            get { return _employeeKey; }
            set { _employeeKey = value; }
        }

        public DateTimeOffset SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }

        public int SalesID
        {
            get { return _saleID; }
            set { _saleID = value; }
        }

        public override void SetDefaultValues()
        {
            _carKey = NullKey;
            _customerKey = NullKey;
            _employeeKey = NullKey;
        }
    }
}

