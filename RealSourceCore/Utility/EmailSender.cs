
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealSourceCore.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("8f0a53016404c556e4ee4908b612c5c3"), Environment.GetEnvironmentVariable("519c32f47ea2ca26c814eb3f7883ee65"))
            {
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "vapeemwaves@gmail.com"},
        {"Name", "Toom"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {"Email",email},}
       }},
        {"Subject",subject},
         {"HTMLPart",htmlMessage}, 
        {"CustomID",
       "AppGettingStartedTest"}
     }
             });


        }
    }
}
