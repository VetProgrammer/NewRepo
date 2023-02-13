namespace DepInjDemoMVC.Services.NonDatabase
{
    public interface IEmailSenderService
    {
        void SendEmail(string email); 
        string Message { get; set; }
    }
    public class EmailSenderService: IEmailSenderService
    {
        // Declare a constructor for a Message to be passed to the controller and the index.cshtml
        public string Message { get; set; } = ""; 
       public void SendEmail(string email) {
            Message = email;
           // Console.WriteLine(email);

        }      
    }
}
