using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kradiy_UI
{
    public static class Kradiy
    {
        public static class User
        {
            public static string login;
            public static string password;
            public static List<string> FoldersToUpload;
            public static List<string> links;
            public static string PathToTempFolder;
            public static MegaApiClient client;
            public static void Login()
            {
                client = new MegaApiClient();
                while (!client.IsLoggedIn)
                {
                    try
                    {
                        client.Login(login, password);

                    }
                    catch
                    {

                    }
                }
                Debug.WriteLine("Logged in");
                
            }
        }
        public static void UploadFolders()
        {
            List<string> folders = new List<string>(Kradiy.User.FoldersToUpload);
            string temporary_folder = Kradiy.User.PathToTempFolder;
        }
    }
   
}
