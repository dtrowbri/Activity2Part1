using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity2Part1.Models;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        // GET: Button
        public ActionResult Index()
        {
            buttons.Add(new ButtonModel(true));
            buttons.Add(new ButtonModel(false));

            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if(mine == "1")
            {
                buttons[0].State = !buttons[0].State;
            } else if(mine == "2")
            {
                buttons[1].State = !buttons[1].State;
            }
            return View("Button", buttons);
        }
    }
}