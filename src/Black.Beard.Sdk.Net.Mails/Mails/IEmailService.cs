using Bb.Sdk.Net.Mails.Models;
using Bb.Sdk.Net.Mails.Renderer;
using System.Net.Mail;

namespace Bb.Sdk.Net.Mails
{
    
    public interface IEmailService
    {
    
        object GenerateMail(RendererResult mailResult, MessageModelBase model);

        void SendMail(object email);


    }


}