namespace WebAppPart32_35.Models
{
    public class EmployeeMockRepository: IEmployee
    {
        private List<Employee> _employee;
        public EmployeeMockRepository()
        {
            _employee = new List<Employee>()
            {
             new Employee() {Id= 1, Name="A", Department="F", Email="K"},
             new Employee() {Id= 2, Name="B", Department="G", Email="L"},
             new Employee() {Id= 3, Name="C", Department="H", Email="M"},
             new Employee() {Id= 4, Name="D", Department="I", Email="N"},
             new Employee() {Id= 5, Name="E", Department="J", Email="O"}
            };

        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employee;
        }

        public Employee GetEmployee(int id)
        {
            var emplist = _employee.FirstOrDefault(x => x.Id == id);

            if (emplist == null)
            {
                throw new InvalidOperationException($"Employee {id} is not found");
            }

            return emplist;
        }
    }
}

