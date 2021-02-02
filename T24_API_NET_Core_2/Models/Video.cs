using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_2.Models
{
    public class Video
    {
        // ATRIBUTOS
        private int id;
        private string title;
        private string director;
        private int cli_id;

        // GETTERS Y SETTERS
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public int Cli_id { get => cli_id; set => cli_id = value; }

        // CONSTRUCTORES
        public ICollection<Video> Videos { get; set; }
    }
}
