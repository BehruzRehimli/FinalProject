using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Mail
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
