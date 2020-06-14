using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusSim.ViewModels
{
    public class ViewModelLocator
    {
        public static MainViewModel MainViewModel => Ioc.Resolve<MainViewModel>();
        public static OverViewViewModel OverViewViewModel => Ioc.Resolve<OverViewViewModel>();
        public static ContactFilterViewModel ContactFilterViewModel => Ioc.Resolve<ContactFilterViewModel>();
        public static AgeViewModel AgeViewModel => Ioc.Resolve<AgeViewModel>();
        public static DefaultViewModel DefaultViewModel => Ioc.Resolve<DefaultViewModel>();
    }
}
