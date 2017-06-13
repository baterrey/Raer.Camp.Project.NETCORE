using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raer_Camp_Project_DEMO.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
