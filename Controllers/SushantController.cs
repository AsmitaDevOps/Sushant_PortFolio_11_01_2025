using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using Sushant_PortFolio_11_01_2025.Models;
namespace Sushant_PortFolio_11_01_2025.Controllers
{
    public class SushantController : Controller
    {
        // GET: Sushant
        public ActionResult Home()
        {
            return View();
        }
     
        //[HttpPost]
        //public ActionResult SendMessage(string Name, string Email, string Message)
        //{
        //    if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Message))
        //    {
        //        TempData["ErrorMessage"] = "All fields are required.";
        //        return RedirectToAction("Contact");
        //    }

        //    try
        //    {
        //        // Format the message that will be sent via WhatsApp
        //        string formattedMessage = HttpUtility.UrlEncode($"New message from: {Name}\nEmail: {Email}\nMessage: {Message}");

        //        // WhatsApp API URL with the formatted message
        //        string whatsAppUrl = $"https://wa.me/9075790773?text={formattedMessage}"; // Replace with your WhatsApp number

        //        // Redirect the user to WhatsApp
        //        return Redirect(whatsAppUrl);
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["ErrorMessage"] = "There was an error sending your message. Please try again later.";
        //        return RedirectToAction("Contact");
        //    }
        //}


            // POST: Home/SendMessage
            //[HttpPost]
            //public ActionResult SendMessage(ContactFormModel model)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        try
            //        {
            //            // Get the email and password from web.config
            //            string email = ConfigurationManager.AppSettings["Email"];
            //            string password = ConfigurationManager.AppSettings["EmailPassword"];

            //            // Setup SMTP client to send email using the retrieved credentials
            //            var smtpClient = new SmtpClient("smtp.gmail.com")
            //            {
            //                Port = 587,
            //                Credentials = new NetworkCredential(email, password),
            //                EnableSsl = true,
            //            };

            //            // Create a new email message
            //            var mailMessage = new MailMessage
            //            {
            //                From = new MailAddress(model.Email),
            //                Subject = "New Message from " + model.Name,
            //                Body = model.Message,
            //                IsBodyHtml = true,
            //            };

            //            // Set recipient email address (your email)
            //            mailMessage.To.Add("shodage880@gmail.com");

            //            // Send the email
            //            smtpClient.Send(mailMessage);

            //            // Add a success message and redirect back to the form
            //            TempData["SuccessMessage"] = "Your message has been sent successfully!";
            //            return RedirectToAction("Home");
            //        }
            //        catch (Exception ex)
            //        {
            //            // Log the exception and show an error message
            //            TempData["ErrorMessage"] = "There was an error sending your message. Please try again later.";
            //            return RedirectToAction("Home");
            //        }
            //    }

            //    // If validation fails, return the user back to the form
            //    return View("Home", model);
            //}
        }

}


