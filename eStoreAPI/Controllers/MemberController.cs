using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace eStoreAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : Controller
    {
        private IMemberRepository repository = new MemberRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetProducts() => repository.GetMembers();

        [HttpPost]
        public IActionResult PostMember(Member member)
        {
            repository.SaveMember(member);
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult DeleteMember(int id)
        {
            var member = repository.GetMember(id);
            if (member == null)
            {
                return NotFound();
            }

            repository.DeleteMember(member);
            return NoContent();
        }

        [HttpPut("id")]
        public IActionResult UpdateMember(int id)
        {
            var member = repository.GetMember(id);
            if (member == null)
            {
                return NotFound();
            }

            repository.UpdateMember(member);
            return NoContent();
        }
    }
}
