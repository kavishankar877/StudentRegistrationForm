using AutoMapper;
using MeachineTest.Data;
using MeachineTest.DTO;
using MeachineTest.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeachineTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StudentController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(StudentRegistrationDto dto)
        {
            var student = _mapper.Map<Student>(dto); 

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Registered", Id = student.StudentId });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            var student = _context.Students.FirstOrDefault(s =>
                s.Username == login.Username && s.Password == login.Password);

            if (student == null)
                return Unauthorized(new { Message = "Invalid username or password" });

            return Ok(new
            {
                Message = "Login successful",
                studentId = student.StudentId,
                username = student.Username
            });
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var students = _context.Students.Include(s => s.Qualifications).ToList();
            return Ok(students);
        }



    }
}


