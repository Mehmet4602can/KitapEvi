namespace WebApplication1.Models
{
    public class KategoriModel
    {
        public int KategoriId { get; set; }
        public string KategoriName { get; set; }
        List<KitapModel> BookList = new List<KitapModel>();
    }
}
