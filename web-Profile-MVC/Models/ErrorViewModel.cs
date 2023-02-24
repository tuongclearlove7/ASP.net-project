using Microsoft.AspNetCore.Mvc;
using web_Profile_MVC.Controllers;

namespace web_Profile_MVC.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId 
            
            => !string.IsNullOrEmpty(RequestId);



    }
}