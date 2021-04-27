using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Model;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryservice;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryservice = categoryService;
        }
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _categoryservice.GetAll();
        }

        [HttpGet("{id}")]
        //[Authorize(Roles = "Admin,User")]
        public ActionResult<Category> Get(int id)
        {
            return _categoryservice.GetById(id);
        }


        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public IActionResult Post(Category category)
        {
            if (_categoryservice.Create(category))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
       // [Authorize(Roles = "Admin")]
        public IActionResult Put(int id, Category category)
        {
            id = category.CategoryId;
            if (_categoryservice.Update(category))
            {
                return Ok();
            }
            return BadRequest();

        }

        [HttpDelete("{id}")]
       // [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            if (_categoryservice.Delete(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}