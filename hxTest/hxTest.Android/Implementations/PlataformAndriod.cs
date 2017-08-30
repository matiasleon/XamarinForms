using hxTest.Common;
using hxTest.Droid.Implementations;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlataformAndriod))]
namespace hxTest.Droid.Implementations
{
    public class PlataformAndriod : IPlataform
    {
        public ISQLitePlatform GetPlatform()
        {
            return new SQLitePlatformAndroid();
        }
    }
}