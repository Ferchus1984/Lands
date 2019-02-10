namespace Lands.Infrastructure
{
    using ViewModels;
    
    public class InstaceLocator 
	{

	#region Propieties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion


        #region Contructors
        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}