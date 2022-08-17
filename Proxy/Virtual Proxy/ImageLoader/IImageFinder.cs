using System.Drawing;

// Щоб наш проксі міг імітувати роботу справжнього об'єкта - вони обидва наслідують один інтерфейс
namespace ImageLoader
{
    interface IImageFinder
    {
        Image getImage();
        
        Image findImage();
    }
}
