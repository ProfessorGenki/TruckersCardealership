﻿using MVVMStarter.Configuration.App;
using MVVMStarter.Models.App;
using MVVMStarter.Models.Base;
using MVVMStarter.Validators.App;


/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called _REPLACEME_.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain.Salesperson
{
    public class Salesperson : DomainClassBase
    {
        private string _name;
        private string _email;
        private string _phone;
        private string _address;
        private int _salespersonId;


        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int SalespersonID { get { return _salespersonId; } set { _salespersonId = value; } }

        public override void SetDefaultValues()
        {
            _name = "John Doe";
            _email = "Example@Email.com";
            _phone = "23954072";
            _address = "Elisagårdsvej 5, 4000 Roskilde";
            _salespersonId = 0;
            Key = NullKey;
        }

        public double Commision
        {
            get
            {
                double commision = 0;
                foreach (var salg in ObjectProvider.SaleCatalog.All)
                {
                    if (salg.SalespersonKey == Key)
                    {
                        Car.Car car = ObjectProvider.CarCatalog.Read(salg.CarKey);
                        if (car != null)
                        {
                            double pris = car.Price;
                            if (car.Price < 100000)
                            {
                                commision += car.Price * 0.05;
                            }
                            else if (car.Price > 100000 && car.Price < 175000)
                            {
                                commision += car.Price * 0.08;
                            }
                            else
                            {
                                commision += car.Price * 0.15;
                            }

                        }
                    }
                }
                return commision;
            }
        }

        //public double TotalCommision
        //{

        //}


    }
}
