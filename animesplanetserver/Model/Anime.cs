using System;
using System.Collections.Generic;

namespace animesplanetserver.Model
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverPicture { get; set; }
        public string Description { get; set; }
        public int NumberOfEpisodes { get; set; }
        public string Stori { get; set; }
        public DateTime AiringDate { get; set; }
        public List<Picture> Pictures { get; set; }
        public List<Music> Musics { get; set; }
        public List<EpicMoment> EpicMoments {get;set;}
        public List<Character> Characters {get;set;}
    }
}