using DBManager.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace DBManager.Views.Helpers
{
    public static class ConnectionImageListHelper
    {
        public static ImageList GetImageList()
        {
            var imageList = new ImageList();

            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/connection.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/database.png"));
            imageList.Images.Add(Image.FromFile($"{Constants.Paths.Resources}/table.png"));

            return imageList;
        }
    }
}
