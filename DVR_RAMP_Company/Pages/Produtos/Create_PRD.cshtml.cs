
using DVR_RAMP_Company.Data;
using DVR_RAMP_Company.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVR_RAMP_Company.Pages.Produtos;
[BindProperties]
public class Create_PRDModel : PageModel

{
    private readonly ApplicationDbContext _db;
    
    public Tb_Product Produtos { get; set; }

    public Create_PRDModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
    }
    public async Task<IActionResult> OnPost(Tb_Product produtos)

    {
        await _db.Tb_Product.AddAsync(produtos);
        await _db.SaveChangesAsync();
        return RedirectToPage("Index");
    }

}
