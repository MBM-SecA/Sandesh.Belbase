using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StudentsApi.Models;
[Route("students")]
[ApiController]
public class StudentController: ControllerBase
{   
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {   
        var students= new string[]{"Cosmic", "Pars"};

        if(students == null)
            return NotFound();

        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult  GetStudentById(string name)
    {
        var students = new string[] {"Dipesh", "Paras"};

        var student = students.Where(x => x == name).FirstOrDefault();
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
        if(student==null)
        return BadRequest();

        return Created("", student);
    }

     [HttpPost]
    [Route("Delete")]

    public ActionResult DeleteStudent(Student student)
    {
        if(student==null)
        return BadRequest();

        return Created("", student);
    }
     [HttpPost]
    [Route("Update")]

    public ActionResult UpdateStudent(Student student)
    {
        if(student==null)
        return BadRequest();

        return Created("", student);
    }
}