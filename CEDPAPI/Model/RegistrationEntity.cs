namespace CEDPAPI.Model
{
    public class RegistrationEntity
    {
        public int Id { get; set; }
        public int IdGrade { get; set; }
        public int IdStudent { get; set; }
        public DateOnly? RegisterDate { get; set; }
    }
}
