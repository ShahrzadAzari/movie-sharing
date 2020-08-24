using System;
using System.ComponentModel.DataAnnotations;


namespace SharedData
{
    public class MovieDataModel
    {
        [Key]
        public string MovieId {get;set;}

        public string UserId {get;set;}

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        [Required , Range(0,10)]
        public float Imdb {get;set;}
        
        [Required , StringLength(1000 , MinimumLength = 50 , ErrorMessage = "{0} length must be between {2} and {1}.")]
        public string Summery {get;set;}
        
        public string ImageUrl {get;set;}
        
    }
}

