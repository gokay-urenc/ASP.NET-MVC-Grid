using MVC_28_Grid_Kavrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_28_Grid_Kavrami.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Makale> makaleler = new List<Makale>
            {
                new Makale
                {
                    id = 1,
                    baslik = "Apocalypse",
                    kategorisi = "News",
                    kaynakca = "Virus",
                    konusu = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla sollicitudin felis vel velit maximus mattis. Nulla sodales tempor sem et aliquam. Nunc feugiat lacinia convallis. Praesent sed tincidunt leo, in sodales tellus. Praesent elementum lorem quis tortor rutrum, in rhoncus quam rhoncus. Mauris non magna fringilla, iaculis justo non, pellentesque enim. Nulla cursus non felis quis lobortis. Nunc ut nisi ac enim placerat tristique eu quis urna. Quisque condimentum justo lorem, id maximus tellus pellentesque non. In purus ipsum, fringilla eu efficitur et, fermentum eu risus. Maecenas suscipit luctus tortor, quis scelerisque justo scelerisque sit amet. Nulla facilisi. Aliquam vitae iaculis quam. Fusce pulvinar imperdiet rutrum. In sed tristique metus, at scelerisque enim. Vivamus non tortor in elit hendrerit varius. Etiam maximus eu massa in venenatis. Phasellus volutpat lacus ornare felis tincidunt, in consequat metus ultricies. Maecenas et tristique felis. Curabitur quis erat sit amet purus posuere gravida. Vivamus at ex at libero posuere blandit. Nunc eu velit mi.",
                    yayinlama_tarihi = DateTime.Now,
                    yazar_ismi = "Negan Lucille"
                },
                new Makale
                {
                    id = 2,
                    baslik = "Animals",
                    kategorisi = "News",
                    kaynakca = "Habitat",
                    konusu = "Fusce nec accumsan lorem. Proin sed hendrerit lorem, sed lobortis eros. Vestibulum commodo tortor quis velit rhoncus, vel congue arcu lacinia. Vivamus ac sem viverra, dictum lorem sit amet, posuere nisi. Duis varius dolor a justo dictum hendrerit. Donec bibendum nisl vitae nunc semper rhoncus. Curabitur risus felis, tincidunt nec bibendum et, porttitor sed lorem. Sed vitae velit non enim blandit volutpat ac sit amet ex. Curabitur rutrum auctor leo sit amet lobortis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed accumsan enim nec est venenatis, ut facilisis magna dictum. Fusce arcu ex, porta varius fringilla sit amet, dignissim vel nibh. Phasellus in pharetra lacus. Aenean scelerisque tristique dapibus. Maecenas ornare leo vel finibus condimentum. Vestibulum sit amet neque id massa laoreet varius. Quisque nunc leo, dictum sed egestas ac, condimentum a orci. Mauris rhoncus, sem vel tincidunt tempor, neque tortor blandit neque, cursus fermentum est nulla nec leo. Duis a consequat sapien. Donec accumsan nisl id mauris ultrices, non commodo sem aliquet. Aliquam consequat, sapien non interdum aliquet, dolor sapien suscipit tortor, non venenatis nibh lorem quis neque. Suspendisse ex ligula, semper in dictum et, molestie quis magna. Etiam luctus nunc a ex semper varius sit amet in neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse commodo facilisis urna, a consectetur leo laoreet in. Curabitur quis dignissim lorem. Duis euismod, sem nec faucibus eleifend, leo est gravida lectus, sed malesuada urna dui nec elit.",
                    yayinlama_tarihi = DateTime.Now,
                    yazar_ismi = "Rick Grimes"
                }
            };
            return View(makaleler);
        }
    }
}