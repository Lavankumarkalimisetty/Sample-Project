using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Project.Models
{
   public class CommonClass
    {
        public bool NetworkConnection()
        {
            if (CrossConnectivity.Current.IsConnected == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
