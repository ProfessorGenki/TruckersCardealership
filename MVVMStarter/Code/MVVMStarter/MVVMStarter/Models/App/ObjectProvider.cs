namespace MVVMStarter.Models.App
{
    /// <summary>
    /// This class just provides a place to define shorthand static
    /// methods for accessing the domain-specific catalogs.
    /// </summary>
    public class ObjectProvider
    {
        public static Images.App.Catalog ImageCatalog
        {
            get { return Images.App.Catalog.Instance; }
        }

        public static Domain.Car. CarCatalog Carcatalog
        {
            get { return Domain.Car.CarCatalog.Instance; }
        }

        public static Domain.Customer.Catalog CustomerCatalog
        {
            get { return Domain.Customer.Catalog.Instance; }
        }

        public static Domain.Salesperson.SPCatalog SPCatalog
        {
            get { return Domain.Salesperson.SPCatalog.Instance; }
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