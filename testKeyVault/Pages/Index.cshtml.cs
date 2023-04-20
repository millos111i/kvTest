using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace testKeyVault.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _conf;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration conf)
        {
            _logger = logger;
            _conf = conf;
        }

        public string Key { get; set; }

        public void OnGet()
        {
            Key = _conf["UserSecret"];
        }
    }
}