using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WCF.Models;

namespace WCF.Controllers
{
    [Route("api/StudentsApi")]
    [ApiController]
    public class StudentsApi : ControllerBase
    {
        {

        //--------------< Class: Controller >---------------------

        #region Controller Init

        private readonly ApplicationDbContext _dbContext;



        public ProjectsController(ApplicationDbContext dbContext)

        {

            //----< Init: Controller >----

            _dbContext = dbContext;

            //----</ Init: Controller >----

        }

        #endregion







        // GET: /api/index

        public List<ProjectModel> Index()

        {

            ///-------------< Index >------------- 



            //--< Get Linq.Query >--

            //*gets last 10 Projects with View_Sum

            var query = (from n in _dbContext.tbl_Projects

                         where n.IsDraft == false

                         orderby n.IDProject descending

                         select n).Take(10);

            //--</ Get Linq.Query >--





            //----< fill Data_to_View >----

            List<ProjectModel> dataList = query.ToList<ProjectModel>();





            //< out >

            //*output to client

            return dataList;

            //</ out >

            ///-------------</ Index >------------- 

        }







        //--------------</ Class: Controller >---------------------

    }
    private readonly WCFContext _context;

        public StudentsApi(WCFContext context)
        {
            _context = context;
        }

        // GET: api/StudentsApi
        [HttpGet]
        public IEnumerable<Student> GetStudent()
        {
            return _context.Student;
        }

        // GET: api/StudentsApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _context.Student.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/StudentsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent([FromRoute] long id, [FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentsApi
        [HttpPost]
        public async Task<IActionResult> PostStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Student.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
        }

        // DELETE: api/StudentsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Student.Remove(student);
            await _context.SaveChangesAsync();

            return Ok(student);
        }

        private bool StudentExists(long id)
        {
            return _context.Student.Any(e => e.StudentId == id);
        }
    }
}