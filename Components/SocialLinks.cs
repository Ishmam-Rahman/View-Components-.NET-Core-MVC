using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Component.Models;

namespace View_Component.Components
{
    [ViewComponent]
    public class SocialLinks : ViewComponent
    {
        public List<SocialIcon> _list = new List<SocialIcon>();
        public SocialLinks()
        {
            _list = SocialIcon.AppSocialIcons();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SocialLinks",_list);
        }
    }       
}
