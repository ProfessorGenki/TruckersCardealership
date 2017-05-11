using MVVMStarter.Models.Base;
using MVVMStarter.Persistency.Base;

/// <summary>
/// TEMPLATE: You must 
/// 1) Create a file called Catalog.cs in your domain folder (under Model/Domain)
/// 2) Delete the entire content of the file
/// 3) Copy-paste the entire content of this template into the file
/// 4) replace the text _REPLACEME_ with the name of your domain
/// 5) Delete this comment
/// </summary>
namespace MVVMStarter.Models.Domain.Salesperson
{
    public class SPCatalog : CatalogBase<Salesperson>
    {
        #region Model Singleton implementation
        private static SPCatalog _instance = null;

        public static SPCatalog Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new SPCatalog();
                return _instance;
            }
        }

        /// <summary>
        /// Use a file-based persistent source
        /// </summary>
        private SPCatalog() : base(new CollectionBase<Salesperson>(), new FileSourceBase<Salesperson>())
        {
        }
        #endregion
    }
}
