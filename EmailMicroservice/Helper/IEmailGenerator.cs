using EmailMicroservice.Models;

namespace EmailMicroservice.Helper
{
    public interface IEmailGenerator
    {
        /// <summary>
        /// Creates an email object for the register action
        /// </summary>
        /// <para name= "username"></para> // Uses the username to address the receiver.
        /// <returns>Email object with a body and subject</returns>
        Email CreateRegisterEmail(string username);
    }
}