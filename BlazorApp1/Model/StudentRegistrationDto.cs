namespace StudentForm.Model
{
    public class StudentRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<QualificationDto> Qualifications { get; set; } = new();
    }
}
 
