using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using EmailMicroservice.Helper;
using EmailMicroservice.Models;
using Microsoft.Extensions.Options;

namespace EmailMicroservice.Services
{
    public interface IEmailService
    { 
        /// <summary>
        /// Sends the Register email to the given email address
        /// </summary>
        /// <param name="email">email address to send the email to</param>
        /// <param name="username">username to address in the email</param>
        /// <returns>Task to send the email</returns>
        Task SendRegisterEmail(string email, string username);
    }
}