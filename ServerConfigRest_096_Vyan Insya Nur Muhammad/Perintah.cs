using ServiceRest_096_Vyan_Insya_Nur_Muhammad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerConfigRest_096_Vyan_Insya_Nur_Muhammad
{
    class Perintah
    {

        ServiceHost hostObjek = null;

        public void aktifkan()
        {
            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server Ready");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        public void matikan()
        {
            
            try
            {
                hostObjek.Close();
                Console.WriteLine("Server Off");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
