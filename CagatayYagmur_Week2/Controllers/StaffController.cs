using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CagatayYagmur_Week2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        // all instances stored in this dictionary.
        static Dictionary<int, Staff> staffList = new Dictionary<int, Staff>();

        // GET: api/<StaffController>
        [HttpGet]
        public List<Staff> Get()
        {
            // return should be list. so dict is turned into list in return.
            return staffList.Values.ToList(); 
        }


        //GET api/<StaffController>/5
        [HttpGet("{id}")]
        public Staff Get(int id)
        {
            return staffList[id];
        }


        // POST api/<StaffController>
        // necessary information is taken from this resource.
        // https://andrewlock.net/model-binding-json-posts-in-asp-net-core/
        [HttpPost]
        public void Post([FromBody] Staff staff)
        {
            staffList.Add(staff.Id, staff);
        }


        // PUT api/<StaffController>/5
        // directly changes all the instance.

        [HttpPut("{id}")]
        public Staff Put(int id, [FromBody] Staff staff)
        {
            staffList[id] = staff;
            return staff;
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public Staff Delete(int id)
        {
            Staff deletedStaff = staffList[id];
            staffList.Remove(id);
            return deletedStaff;
        }
    }
}
