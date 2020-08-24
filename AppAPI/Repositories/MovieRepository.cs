using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SharedData;


namespace AppAPI.Repositories
{
    public class MovieRepository
    {
        private MyDbContext _dbContext;
        public MovieRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MovieDataModel[] GetAllMovies()
        {
            return _dbContext.Movies.ToArray();
        }

        public void PostYourMovie(MovieDataModel movieDataModel)
        {
            movieDataModel.MovieId = $"{Guid.NewGuid()}-{Guid.NewGuid()}";
            _dbContext.Add(movieDataModel);
            _dbContext.SaveChanges();
        }

        public void RemoveMovie(string title)
        {
            MovieDataModel thisMovie = _dbContext.Movies.Where(m => m.Title == title).First();
            string filePath = "C:\\git\\AP98992\\final_project\\MovieSharing\\AppUI\\wwwroot" + thisMovie.ImageUrl;
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
            _dbContext.Remove(thisMovie);
            _dbContext.SaveChanges();
        }

        public ActionResult<MovieDataModel[]> FindUsersMovie(string userId)
        {
            return _dbContext.Movies.Where(m => m.UserId == userId).ToArray();
        }

        public ActionResult<MovieDataModel> FindByTitle(string title)
        {
            return _dbContext.Movies.Where(m=>m.Title == title).First();
        }

        public void UpdateMovie(string title , MovieDataModel movieDataModel)
        {
            MovieDataModel thisMovie = _dbContext.Movies.Where(m=>m.Title == title).First();
            _dbContext.Remove(thisMovie);
            _dbContext.Add(movieDataModel);
            _dbContext.SaveChanges();
        }
    }
}