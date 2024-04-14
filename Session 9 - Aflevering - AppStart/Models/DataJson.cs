using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9___Aflevering___AppStart.Models
{
    public class DataJson
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int Id { get; set; }
            public bool Adult { get; set; }
            public string BackdropPath { get; set; }
            public int MovieId { get; set; }
            public string OriginalLanguage { get; set; }
            public string OriginalTitle { get; set; }
            public string Overview { get; set; }
            public float Popularity { get; set; }
            public string PosterPath { get; set; }
            public string ReleaseDate { get; set; }
            public string Title { get; set; }
            public bool Video { get; set; }
            public float VoteAverage { get; set; }
            public int VoteCount { get; set; }
            public Genre[] Genres { get; set; }
        }

        public class Genre
        {
            public int Id { get; set; }
            public int GenreId { get; set; }
            public string Name { get; set; }
        }

    }
}
