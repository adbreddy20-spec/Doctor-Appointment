namespace HospitalMVC.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Time { get; set; }
        public bool IsApproved { get; set; }
    }
}
