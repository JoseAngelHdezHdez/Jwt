using Jwt.Models;

namespace Jwt.Constants
{
    public class CountryConstants
    {
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel() {name = "Argentina"},
            new CountryModel() {name = "Mexico"},
            new CountryModel() {name = "España"},
            new CountryModel() {name = "Peru"}
        }; 
    }
}
