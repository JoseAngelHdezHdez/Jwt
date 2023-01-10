using Jwt.Models;

namespace Jwt.Constants
{
    public class EmployeeConstants
    {
        public static List<EmplyeeModel> Employees = new List<EmplyeeModel>() 
        {
            new EmplyeeModel() {FirstName = "Tomas", LastName = "Aliaga", Email = "aliaga@gmail.com"},
            new EmplyeeModel() {FirstName = "Martin", LastName = "Torrentera", Email = "martin@gmail.com"},
            new EmplyeeModel() {FirstName = "Martin", LastName = "Muños", Email = "muñosmartin@gmail.com"},
        };
    }
}
