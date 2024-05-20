using WebArt.Model.Entities;

namespace WebArt.Api.Services
{
    public interface IPaintingService
    {
        IEnumerable<Painting> GetPaintings();
        void AddPainting(Painting painting);
        void UpdatePainting(Painting painting);
        void DeletePainting(int id);
    }
}
