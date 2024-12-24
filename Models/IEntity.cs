using System;

namespace FacebookGoogleAPIProject.Models
{
    public interface IEnity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
    }
   
}