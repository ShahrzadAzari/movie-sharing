using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SharedData;

namespace Requests
{
    public class Movie
    {
        private HttpClient _Http;
        public Movie(HttpClient Http)
        {
            _Http = Http;
        }
        public Task<MovieDataModel[]> ShowingMovies()
        {
            try
            {
                var uri = @"http://localhost:5000/api/Movies";
                return _Http.GetFromJsonAsync<MovieDataModel[]>(uri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.Run(()=>new MovieDataModel[0]);
            }
        }
        public Task<MovieDataModel[]> ShowingMovies(string username)
        {
            try
            {
                var uri = @"http://localhost:5000/api/Movies/you/" + username ;
                return _Http.GetFromJsonAsync<MovieDataModel[]>(uri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Task.Run(()=>new MovieDataModel[0]);
            }
        }
        public Task AddingMovie(MovieDataModel movieToAdd)
        {
            var uri = @"http://localhost:5000/api/Movies/add";
            return _Http.PostAsJsonAsync(uri , movieToAdd);
        }
        public void DeleteMovie(string title)
        {
            try
            {
                var uri = @"http://localhost:5000/api/Movies/delete/" + title;
                _Http.DeleteAsync(uri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Task EditMovie(string previousTitle , MovieDataModel movieToEdit)
        {
            var uri = @"http://localhost:5000/api/Movies/edit/" + previousTitle;
            return _Http.PutAsJsonAsync(uri , movieToEdit);
        }
    }
}