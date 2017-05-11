namespace MVVMStarter.Models.App
{

    //Bruger da vi vha. et enkelt navn eks. ImageCatalog kan referer til hvor cataloget er gemt.
    public class ObjectProvider
    {
        public static Images.App.Catalog ImageCatalog
        {
            get { return Images.App.Catalog.Instance; }
        }

        public static Domain.Car.Catalog CarCatalog
        {
            get { return Domain.Car.Catalog.Instance; }
        }

        public static Domain.Customer.Catalog CustomerCatalog
        {
            get { return Domain.Customer.Catalog.Instance; }
        }

        public static Domain.Salesperson.Catalog SalespersonCatalog
        {
            get { return Domain.Salesperson.Catalog.Instance; }
        }

        public static Domain.Sale.Catalog SaleCatalog
        {
            get { return Domain.Sale.Catalog.Instance; }
        }

        //public static MVVMStarter.Models.Domain._REPLACEME_.Catalog _REPLACEME_Catalog
        //{
        //    get { return MVVMStarter.Models.Domain._REPLACEME_.Catalog.Instance; }
        //}
    }
}