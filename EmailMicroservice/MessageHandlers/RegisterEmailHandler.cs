using System;
using System.Text.Json;
using System.Threading.Tasks;
using EmailMicroservice.Messages;
using EmailMicroservice.Services;
using MessageBroker;

namespace EmailMicroservice.MessageHandlers
{
    public class RegisterEmailHandler: IMessageHandler<RegisterMessage>
    {
        private readonly IEmailService _emailService;

        public RegisterEmailHandler(IEmailService emailService)
        {
            _emailService = emailService;
        }        
        
        public Task HandleMessageAsync(string messageType, RegisterMessage sendable)
        {
            Task.Run(() => { _emailService.SendRegisterEmail(sendable.Email, sendable.Username); });
            Console.WriteLine(sendable);
            return Task.CompletedTask;
        }

        public Task HandleMessageAsync(string messageType, byte[] obj)
        {
            Console.WriteLine(messageType);
            Console.WriteLine(obj);
            return HandleMessageAsync(messageType, JsonSerializer.Deserialize<RegisterMessage>((ReadOnlySpan<byte>) obj, (JsonSerializerOptions) null));
        }
    }
}