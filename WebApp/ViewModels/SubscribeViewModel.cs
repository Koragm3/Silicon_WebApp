using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels;

public class SubscribeViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "E-mail address", Prompt ="Your Email")]
    public string Email { get; set; }
    public bool DailyNewsletter { get; set; }
    public bool AdvertisingUpdates { get; set; }
    public bool WeekinReview { get; set; }
    public bool EventUpdates { get; set; }
    public bool StartupWeekly { get; set; }
    public bool Podcasts { get; set; }
}
