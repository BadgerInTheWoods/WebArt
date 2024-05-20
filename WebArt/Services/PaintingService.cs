using Microsoft.EntityFrameworkCore;
using WebArt.Data;
using WebArt.Model.Entities;

namespace WebArt.Api.Services
{
    public class PaintingService : IPaintingService
    {
        private readonly AppDbContext _context;
        public PaintingService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPainting(Painting painting)
        {
            _context.Paintings.Add(painting);
            _context.SaveChanges();
        }

        public void DeletePainting(int id)
        {
            var painting = _context.Users.Find(id);
            if (painting != null)
            {
                _context.Users.Remove(painting);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Painting> GetPaintings()
        {
            return _context.Paintings.ToList();
        }

        public void UpdatePainting(Painting painting)
        {
            _context.Entry(painting).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
