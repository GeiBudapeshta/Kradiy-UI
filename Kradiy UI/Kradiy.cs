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
            public static List<Uri> links;
            public static string PathToTempFolder;
            public static string PathToDonwloadFolder;
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
        public static void DownloadFolder(int Folder_Index)
        {

        }
        public static List<string> ListFoldersInRoot()
        {
            IEnumerable<INode> nodes = Kradiy.User.client.GetNodes();
            List<string> folders = new List<string>();
            List<Uri> links = new List<Uri>();
            INode parent = nodes.Single(n => n.Type == NodeType.Root);
            IEnumerable<INode> children = nodes.Where(x => x.ParentId == parent.Id);
            foreach (INode node in children)
            {
                folders.Add(node.Name);
                //links.Add(Kradiy.User.client.GetDownloadLink(node));
            }
            //Kradiy.User.links = links;
            return folders;
        }
        public static double GetUsedSpaceOnServer()
        {
            return Math.Round(Convert.ToDouble(Kradiy.User.client.GetAccountInformation().UsedQuota) / 1000000000, 2);
        }
    }
   
}
