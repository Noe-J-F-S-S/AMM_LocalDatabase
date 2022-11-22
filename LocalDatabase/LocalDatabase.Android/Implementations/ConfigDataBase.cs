using LocalDatabase.Droid.Implementations;
using System.IO;
using Xamarin.Forms;
using LocalDatabase.Interfaces;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace LocalDatabase.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase 
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}
