namespace WebAppPart32_35.Models
{
    public interface IEmployee
    {
        public Employee GetEmployee(int id);
        public IEnumerable<Employee> GetAllEmployees();
    }

}
