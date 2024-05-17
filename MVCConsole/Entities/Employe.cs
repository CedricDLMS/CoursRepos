namespace Entities
{
    public class Employe
    {
        public required int Id {  get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}€";
        }
    }
}
