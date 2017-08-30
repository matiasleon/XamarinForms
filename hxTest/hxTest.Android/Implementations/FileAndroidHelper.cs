
using System.IO;
using hxTest.Common;
using hxTest.Droid.Implementations;
using Xamarin.Forms;
using Environment = System.Environment;


[assembly: Dependency(typeof(FileAndroidHelper))]
namespace hxTest.Droid.Implementations
{
    public class FileAndroidHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}