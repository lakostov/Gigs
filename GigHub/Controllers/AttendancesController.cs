using GigHub.Dtos;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GigHub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;
        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }
        [AcceptVerbs("GET", "POST")]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();

            

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }

    }
}
