using AspNetCoreAPI.Data;
using AspNetCoreAPI.DTO;
using AspNetCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace AspNetCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FormController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPut("create-form")]
        public ActionResult<FormDTO> CreateRequest(FormDTO formDTO)
        {
            try
            {
                if(formDTO == null)
                {
                    return NotFound();
                }

                var form = new FormModel
                {
                    Mc_Nickname = formDTO.Mc_Nickname,
                    Dc_Tag = formDTO.Dc_Tag,
                    Reason = formDTO.Reason,
                };

                _context.Requests.Add(form);
                _context.SaveChanges();

                return Ok("Success!");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }
    }
}
