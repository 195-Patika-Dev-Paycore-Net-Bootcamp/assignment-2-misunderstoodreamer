namespace CagatayYagmur_Week2
{
    public class Staff
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [DateOfBirth]
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }

    }


}
