using System.Drawing;
using System.IO;
using System.Net;

// Наш "великий" об'єкт
namespace ImageLoader
{
    class ImageFinder : IImageFinder
    {
        private Image image;
        private int[] resolution;
        public ImageFinder(int[] resolution) 
        {
            this.resolution = resolution;
        }

        // довготривала операція - з моїм інетом секунд 5
        // я спеціально брав картинки здоровенних масштабів, 4к, 8к, 16к...
        public Image findImage()
        {
            int width = resolution[0];
            int height = resolution[1];

            // ми звертаємося до сайту, який перенаправляє нас на випадкове зображення, вказуємо при цьому бажані розміри
            string final_url = GetUrl($"https://source.unsplash.com/random/{width}x{height}?sig=incrementingIdentifier");
            
            Image image = Image.FromStream(new MemoryStream(new WebClient().DownloadData(final_url)));

            this.image = image;

            return image;
        }

        public Image getImage()
        {
            return image;
        }

        // допоміжний метод для знаходження URL після перенаправлення з URL, яке видає рандомне URL 
        // з зображенням (як складно)
        // взято але змінено з:
        // https://stackoverflow.com/questions/704956/getting-the-redirected-url-from-the-original-url
        private string GetUrl(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.AllowAutoRedirect = false; 

            webRequest.Timeout = 10000;           
            webRequest.Method = "HEAD";
            
            HttpWebResponse webResponse;
            using (webResponse = (HttpWebResponse)webRequest.GetResponse())
            {
                if ((int)webResponse.StatusCode >= 300 &&
                    (int)webResponse.StatusCode <= 399)
                {
                    string urlString = webResponse.Headers["Location"];
                    webResponse.Close();
                    return urlString;
                }
            }

            return "https://images.unsplash.com/photo-1658163724548-29ef00812a54";
        }
    }
}
