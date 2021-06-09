using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.DTO
{
    public class ListDataDTO
    {
        public int Id { get; set; }
        public string EmriFilmit { get; set; }
        public string EmriRegjisorit { get; set; }
        public DateTime? DataProdhimit { get; set; }
        public int? Minutat { get; set; }
        public string Vleresimi { get; set; }
        public string Shqiptar { get; set; }
        public string Kategoria { get; set; }
        public int? Buxheti { get; set; }
        public int? Invalidated { get; set; }
    }
}
