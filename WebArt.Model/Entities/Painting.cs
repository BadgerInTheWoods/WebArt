using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebArt.Model.Entities
{
    public class Painting
    {
        public int Id { get; set; }
        public string PaintingName { get; set; }
        public DateOnly CreationDate { get; set; }
        public string ArtistName { get; set; }
        public string ArtistSurname { get; set; }
    }
}
