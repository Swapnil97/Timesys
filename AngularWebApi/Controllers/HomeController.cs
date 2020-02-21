
using System;
using System.Linq;
using System.Web.Http;
using AngularWebApi.Models;

namespace AngularWebApi.Controllers
{
    public class HomeController : ApiController
    {
        public string Index()
        {
            return "Service is running";
        }

        [HttpPost]
        [Route("api/Home/PostEmaployee")]
        public IHttpActionResult PostEmaployee([FromBody] EntityFormViewModel data)
        {
            AngularDBEntities objEntity = new AngularDBEntities();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //Mapping
                EntryForm u = new EntryForm()
                {
                    ID = data.ID,
                    Name=data.Name,
                    Email=data.Email,
                    Description=data.Description,
                    Gender=data.Gender,
                    Java=data.Java,
                    Net=data.Net,
                    UI=data.UI,
                    //City=data.City               function here that converts array string into comma seperated string
                    City = String.Join(", ", data.City)
            };

                objEntity.EntryForms.Add(u);
                objEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(data);
        }
    }
}
