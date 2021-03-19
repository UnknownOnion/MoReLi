using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media.Imaging;


namespace MoReLi
{
    class SewingPatternLoader
    {
        private static SewingPatternLoader instance = null;
        

        private SewingPatternLoader()
        {

        }

        public static SewingPatternLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SewingPatternLoader();
                }
                return instance;
            }
        }

        public SewingPattern GetSewingPattern(string folderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            SewingPattern sewingPattern = new SewingPattern();
            List<FileInfo> files = new List<FileInfo>();
            
            foreach (FileInfo item in directory.GetFiles())
            {
                if(item.Extension.Equals(".png")||item.Extension.Equals(".jpg")|| item.Extension.Equals(".jpeg"))
                {
                    sewingPattern.Image = new BitmapImage(new Uri(item.FullName));
                }

                if(item.Extension.Equals(".pdf"))
                {
                    files.Add(item);
                }
            }
            sewingPattern.Files = files.ToArray();

            sewingPattern.Name = directory.Name;

            return sewingPattern;
        }
    }
}
