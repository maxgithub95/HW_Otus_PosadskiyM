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
        
        WebClient myWebClient = new WebClient();
        public void Download(string _remoteUri, string _fileName)
        {
         Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", _fileName, _remoteUri);
            myWebClient.DownloadFile(_remoteUri, _fileName);
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", _fileName, _remoteUri);
        }
       
    }
}
// = "https://zastavok.net/download/61117/1920x1200/";
//= "bigimage.jpg";