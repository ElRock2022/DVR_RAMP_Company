
using DVR_RAMP_Company.Data;
using DVR_RAMP_Company.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DVR_RAMP_Company.Pages.Produtos;
[BindProperties]
public class Edit_PRDModel : PageModel

{
    private readonly ApplicationDbContext _db;
 
    public Tb_Product Produtos { get; set; }  

    public Edit_PRDModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Produtos = _db.Tb_Product.FirstOrDefault(u => u.Id == id);
    }
    public async Task<IActionResult> OnPost()

    {
        _db.Tb_Product.Update(Produtos);
        await _db.SaveChangesAsync();
        return RedirectToPage("Index");
    }

}
