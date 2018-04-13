using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class FollowingsViewModel
    {
        public IEnumerable<ApplicationUser> ArtistsFollowed { get; set; }
        public bool ShowAction { get; set; }
    }
}