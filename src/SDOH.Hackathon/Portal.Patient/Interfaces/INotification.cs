namespace Portal.Patient.Interfaces
{
    public interface INotification
    {
        public int NotificationTypeID { get; set; }
        public string Message { get; set; }
    }
}
