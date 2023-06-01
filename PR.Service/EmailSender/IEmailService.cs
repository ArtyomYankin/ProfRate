using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.EmailSender
{
    public interface IEmailService
    {
        string SendCodeToEmail (string email);
    }
}
