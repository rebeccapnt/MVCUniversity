using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MvcUniversity.Controllers;

public class StudentController : Controller
{
    private readonly MvcUniversityContext _context;


    public StudentController(MvcUniversityContext context)
    {
        _context = context;
    }
    // GET: Students
    public async Task<IActionResult> Index()
    {
        var students = await _context.Students.ToListAsync();
        return View(students);
    }


}