using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StudentsApi.Models;
using StudentsApi.Data;
[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{   
    private StudentContext db { get; set; }
    public StudentController(StudentContext _db)
    {
        db = _db;
    }
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {   
        var students= db.Students.ToList();

        if(students == null)
            return NotFound();

        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult  GetStudentById(string name)
    {

        var student = db.Students.Find(name);
        if(student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }

    [HttpPost]
    [Route("Add")]

    public ActionResult CreateStudent(Student student)
    {
        db.Students.Add(student);
        db.SaveChanges();

        if(student==null)
        return BadRequest();

        return Created("", student);
    }

     [HttpPost]
    [Route("Delete")]

    public ActionResult DeleteStudent(Student student)
    {
        db.Students.Attach(student);
        db.Students.Remove(student);
        db.SaveChanges();
        if(student==null)
        return BadRequest();

        return Created("", student);
    }
     [HttpPost]
    [Route("Update")]

    public ActionResult UpdateStudent(Student student)
    {
        db.Students.Attach(student);
        db.Students.Update(student);
        db.SaveChanges();
        if(student==null)
        return BadRequest();

        return Created("", student);
    }
}