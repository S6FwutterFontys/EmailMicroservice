using EmailMicroservice.Models;

namespace EmailMicroservice.Helper
{
    public class EmailGenerator : IEmailGenerator
    {
        public Email CreateRegisterEmail(string username) {
            var message = new Email
            {
                Subject = "Welcome to Fwutter!",
                Body =
                    "<h2><span>Hey there "+ username+",</span></h2>\n<p style=\"color: #2e6c80;\"><span style=\"color: #000000;\">You have successfully created an account on Fwutter.</p> <p> Please enjoy your stay!</span></p>\n<p>&nbsp;</p>"
            };
            return message;
        }
    }
}