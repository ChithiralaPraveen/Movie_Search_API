using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MovieReview.Data;
using MovieReview.Models;

namespace Movie_Search_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Review review)
        {
   
                _context.Review.Add(review);
                _context.SaveChanges();
            return Ok("Review added");
        }

        [HttpGet]
        [Route("Getall")]
        public IActionResult Getall()
        {

            var data = _context.Review.ToList();            
            return Ok(data);
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int reviewid)
        {
            var itemToDelete = _context.Review.Where(col => col.Id == reviewid).First();
            _context.Review.Remove(itemToDelete);
            _context.SaveChanges();
            return Ok("Review deleted");
        }

    }
}
