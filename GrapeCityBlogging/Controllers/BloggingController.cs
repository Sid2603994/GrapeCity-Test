using GrapeCityBlogging.Data.DBContext;
using GrapeCityBlogging.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrapeCityBlogging.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class BloggingController : ControllerBase
    {

        private readonly ILogger<BloggingController> _logger;
        private readonly AppDBContext _dbContext;

        public BloggingController(ILogger<BloggingController> logger, AppDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("ListAll")]
        public IList<tbl_blogs> ListAllBlogs()
        {
            try
            {
                var blogsList = _dbContext.Blogs.AsQueryable().ToList();
                return blogsList;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        [HttpPut]
        [Route("EditById")]
        public ActionResult<tbl_blogs> EditBlogById(int blogId)
        {
            try
            {
                var blog = _dbContext.Blogs.AsQueryable().Where(x => x.BlogId == blogId).FirstOrDefault();
                return blog;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost]
        [Route("Insert")]
        public ActionResult<string> InsertBlog(tbl_blogs input)
        {
            try
            {
                var blog = _dbContext.Blogs.AsQueryable().Where(x => x.BlogId == input.BlogId).First();
                if(blog != null)
                {
                    return Ok("Already Exists!!");
                }
                var AddBlog = _dbContext.Blogs.Add(input);
                return Ok("Inserted!!");
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public ActionResult<string> DeleteBlog(int blogId)
        {
            try
            {
                var blog = _dbContext.Blogs.AsQueryable().Where(x => x.BlogId == blogId).FirstOrDefault();
                var deleteBlog = _dbContext.Blogs.Remove(blog);
                return Ok("Deleted");
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
