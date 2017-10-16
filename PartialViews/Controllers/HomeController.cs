using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> images = new List<string>();
            images.Add("http://www.freedigitalphotos.net/images/img/homepage/87357.jpg");
            images.Add("http://i164.photobucket.com/albums/u8/hemi1hemi/COLOR/COL9-6.jpg");
            images.Add("https://media.giphy.com/media/3o6ZsWmQDJNIgkv2lq/source.gif");
            images.Add("https://media.giphy.com/media/zXmbOaTpbY6mA/giphy.gif");
            images.Add("https://media.giphy.com/media/ZVik7pBtu9dNS/giphy.gif");
            return View(images);
        }

        public ActionResult About()
        {
            List<string> images = new List<string>();
            images.Add("https://media.giphy.com/media/2f9bV955ui1aw/giphy.gif");
            images.Add("https://media.giphy.com/media/1Agdw2w4UKtgs/giphy.gif");
            images.Add("https://media.giphy.com/media/3o6ZsWmQDJNIgkv2lq/source.gif");
            images.Add("https://media.giphy.com/media/2OGMSYadgFbdm/source.gif");
            images.Add("https://media.giphy.com/media/ZVik7pBtu9dNS/giphy.gif");
            return View(images);
        }

        public ActionResult Contact()
        {
            List<string> images = new List<string>();
            images.Add("https://media.giphy.com/media/2f9bV955ui1aw/giphy.gif");
            images.Add("https://media.giphy.com/media/1Agdw2w4UKtgs/giphy.gif");
            images.Add("https://media.giphy.com/media/3o6ZsWmQDJNIgkv2lq/source.gif");
            images.Add("https://media.giphy.com/media/2OGMSYadgFbdm/source.gif");
            images.Add("https://media.giphy.com/media/ZVik7pBtu9dNS/giphy.gif");
            return View(images);
        }
    }
}