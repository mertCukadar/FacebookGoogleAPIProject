using FacebookGoogleAPIProject.Models;
using FacebookGoogleAPIProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FacebookGoogleAPIProject.Controllers{
    public class UserController:Controller{
        private readonly AppDbContext _context;
        public UserController(AppDbContext context){
            _context = context;
        }
        public IActionResult Index(){
            var users = _context.Users.ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user){
            if(ModelState.IsValid){
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        public IActionResult Delete(int id){
            var user = _context.Users.Find(id);
            if (user != null){
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}