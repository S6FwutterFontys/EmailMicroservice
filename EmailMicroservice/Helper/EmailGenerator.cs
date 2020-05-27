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
                    "<h1><span>Welcome "+ username+", to Fwutter!</span></h1>\n<h2 style=\"color: #2e6c80;\"><span style=\"color: #000000;\">You have successfully created an account on Fwutter. Enjoy your stay!</span></h2>\n<p>&nbsp;</p>"
            };
            return message;
        }
    }
}