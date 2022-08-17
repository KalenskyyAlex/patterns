using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

// Наш проксі, який чекає, доки ImageFinder знайде картинку, натомість дає екран завантаження
namespace ImageLoader
{
    class ImageFinderProxy : IImageFinder
    {
        private ImageFinder finder;
        private PictureBox pictureBox;
        
        public ImageFinderProxy(ImageFinder finder, PictureBox pictureBox)
        {
            this.finder = finder;
            this.pictureBox = pictureBox;
        }

        // обережно - мультипотокове програмування
        public Image findImage()
        {
            // запускаємо паралельно до роботи програми, щоб та не висіла
            Task task = Task.Run(() => { pictureBox.Image = finder.findImage(); });

            // тимчасово повертаємо гіфку "loading" поки не отримаємо зображення
            return Properties.Resources.loading; ;
        }

        // Тут все просто ніби
        public Image getImage()
        {
            return finder.getImage();
        }
    }
}
