using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Services
{

    public interface IEmailService
    {
        Task SendEmail(Email email); 
    }
    
    
}
