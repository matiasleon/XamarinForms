using SQLite.Net.Interop;

namespace hxTest.Common
{
    public interface IPlataform
    {
        ISQLitePlatform GetPlatform();
    }
}
