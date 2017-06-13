using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Raer_Camp_Project_DEMO.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
