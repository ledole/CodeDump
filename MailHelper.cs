using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace MvcCMSFramework
{
    public class MailHelper: IDisposable
    {

        ///// <summary>
        ///// Sends an mail message
        ///// </summary>
        ///// <param name="from">Sender address</param>
        ///// <param name="to">Recepient address</param>
        ///// <param name="bcc">Bcc recepient</param>
        ///// <param name="cc">Cc recepient</param>
        ///// <param name="subject">Subject of mail message</param>
        ///// <param name="body">Body of mail message</param>
        public static void SendMailMessage(string from, string displayName, string to, string bcc, string cc, string subject, string body)
        {
            SmtpClient mSmtpClient = new SmtpClient();
            // Instantiate a new instance of MailMessage
            MailMessage mMailMessage = new MailMessage();

            // Set the sender address of the mail message
            mMailMessage.From = new MailAddress(from, displayName);
            // Set the recepient address of the mail message
            mMailMessage.To.Add(new MailAddress(to));
            // Check if the bcc value is null or an empty string
            if ((bcc != null) && (bcc != string.Empty))
            {
                // Set the Bcc address of the mail message
                mMailMessage.Bcc.Add(new MailAddress(bcc));
            }

            // Check if the cc value is null or an empty value
            if ((cc != null) && (cc != string.Empty))
            {
                // Set the CC address of the mail message
                mMailMessage.CC.Add(new MailAddress(cc));
            }       // Set the subject of the mail message
            mMailMessage.Subject = subject;
            // Set the body of the mail message
            mMailMessage.Body = body;
            // Set the format of the mail message body as HTML
            mMailMessage.IsBodyHtml = true;
            // Set the priority of the mail message to normal
            mMailMessage.Priority = MailPriority.Normal;

            // Instantiate a new instance of SmtpClient
            //SmtpClient mSmtpClient = new SmtpClient();
            //mSmtpClient.Host = "smtp.gmail.com";
            //mSmtpClient.Port = 465;
            //mSmtpClient.EnableSsl = true;



            // Send the mail message

            mSmtpClient.Send(mMailMessage);
        }


        public struct VCalendar
        {
            public int year, month, day, hour, minute, second, duration;
            public string summary, location, method;
        }


        public static void calInvite(VCalendar calEvent)
        {
            SmtpClient sc = new SmtpClient();
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("ahmed_dagga_84@hotmail.com", "Ahmed Abu Dagga");
            msg.To.Add(new MailAddress("youremail@host.com", "Your Name"));
            msg.Subject = "Send Calendar Appointment Email";
            msg.Body = "Here is the Body Content";

            StringBuilder str = new StringBuilder();
            str.AppendLine("BEGIN:VCALENDAR");
            //Meeting Name
            str.AppendLine("PRODID:-//Ahmed Abu Dagga Blog");
            str.AppendLine("VERSION:2.0");
            str.AppendLine("METHOD:REQUEST");
            str.AppendLine("BEGIN:VEVENT");
            //Meeting Start Time
            str.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow.AddHours(2)));
            str.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
            //Meeting End Time
            str.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow.AddHours(3)));
            //Location
            str.AppendLine("LOCATION: Dubai");
            //Guid (Store in Mig Table)
            str.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
            //Description
            str.AppendLine(string.Format("DESCRIPTION:{0}", msg.Body));
            str.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", msg.Body));
            //Summary
            str.AppendLine(string.Format("SUMMARY:{0}", msg.Subject));
            //From
            str.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", msg.From.Address));
            //List Attendees
            str.AppendLine(string.Format("ATTENDEE;CN=\"{0}\";RSVP=TRUE:mailto:{1}", msg.To[0].DisplayName, msg.To[0].Address));

            //Alert Settings
            str.AppendLine("BEGIN:VALARM");
            //When to trigger alarm
            str.AppendLine("TRIGGER:-PT15M");
            str.AppendLine("ACTION:DISPLAY");
            //Alert Description
            str.AppendLine("DESCRIPTION:Reminder");
            str.AppendLine("END:VALARM");
            str.AppendLine("END:VEVENT");
            str.AppendLine("END:VCALENDAR");
            ContentType ct = new ContentType("text/calendar");
            ct.Parameters.Add("method", "REQUEST");
            AlternateView avCal = AlternateView.CreateAlternateViewFromString(str.ToString(), ct);
            msg.AlternateViews.Add(avCal);

            sc.Send(msg);
        }
    }
}