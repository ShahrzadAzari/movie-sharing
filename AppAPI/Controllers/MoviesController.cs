using AppAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using SharedData;
using Microsoft.AspNetCore.Authorization;
using System;

namespace AppAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private MovieRepository _myRepo;

        public MoviesController(MovieRepository myRepo)
        {
            _myRepo = myRepo;
        }
            
        [HttpGet]
        public ActionResult<MovieDataModel[]> ShowAllMovies()
        {
            return _myRepo.GetAllMovies();
        }
                         
        [Authorize]
        [HttpPost("add")]
        public ActionResult<MovieDataModel> AddYourMovie([FromBody]MovieDataModel movieDataModel)
        {
            _myRepo.PostYourMovie(movieDataModel);
            return Created(@"http://localhost:5002/you/movies", movieDataModel);
        }

        [Authorize]
        [HttpDelete("delete/{title}")]
        public ActionResult<MovieDataModel> Delete(string title)
        {
           try{
               _myRepo.RemoveMovie(title);
           }
           catch(Exception e){
               return NotFound(e.Message);
           }
           return Ok();
        }

        [Authorize]
        [HttpGet("you/{username}")]
        public ActionResult<MovieDataModel[]> GetUsersMovies(string username)
        {
            return _myRepo.FindUsersMovie(username);
        }

        [Authorize]
        [HttpPut("edit/{title}")]
        public ActionResult<MovieDataModel> Update(string title , [FromBody]MovieDataModel movieDataModel)
        {
           try{
               _myRepo.UpdateMovie(title,movieDataModel);
           }
           catch(Exception e){
               return NotFound(e.Message);
           }
           return Ok();
        }
    }
}
