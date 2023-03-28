using DVR_RAMP_Company.Data;
using DVR_RAMP_Company.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVR_RAMP_Company.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Tb_Product> Produtos { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Produtos = _db.Tb_Product;
        }
    }
}
