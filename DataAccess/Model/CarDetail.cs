namespace DataAccess.Model
{
    public class CarDetail
    {

        public string CarID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int DaysSinceRegistration { get; set; }


    }
}
