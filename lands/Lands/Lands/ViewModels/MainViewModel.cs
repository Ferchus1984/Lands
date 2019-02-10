//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Xamarin.Forms;

namespace Lands.ViewModels
{
	public class MainViewModel
	{
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;

        }
        #endregion

        #region
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }


        #endregion

    }
}