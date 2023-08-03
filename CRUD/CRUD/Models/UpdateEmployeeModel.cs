namespace CRUD.Models
{
    public class UpdateEmployeeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }

        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Department { get; set; }
    }
}
