using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    internal class ImageDownloader
    {
        
        string remoteUri{get;set;}
        string fileName { get; set; }

        WebClient myWebClient;
        public ImageDownloader(string _remoteUri, string _fileName)
        {   
            myWebClient = new WebClient();
            remoteUri = _remoteUri;
            fileName = _fileName;
            
        }

        public void Download()
        {
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
            myWebClient.DownloadFile(remoteUri, fileName);
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
        }
       
    }
}
// = "https://zastavok.net/download/61117/1920x1200/";
//= "bigimage.jpg";