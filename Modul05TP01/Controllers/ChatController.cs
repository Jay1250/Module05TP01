using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;

namespace Modul05TP01.Controllers
{
    public class ChatController : Controller
    {
        private static List<Chat> chats = Chat.GetMeuteDeChats();

        // GET: Chat
        public ActionResult Index()
        {
            return View(chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int? id)
        {
            if(id != null)
            {
                Chat chat = chats.FirstOrDefault(c => c.Id == id);
                if(chat != null)
                {
                    return View(chat);
                }

            }
            return RedirectToAction("Index");
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id != null)
            {
                Chat chat = chats.FirstOrDefault(c => c.Id == id);
                if(chat != null)
                {
                    return View(chat);
                }

            }
            return RedirectToAction("Index");
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Chat chat = chats.FirstOrDefault(c => c.Id == id);
                if(chat != null)
                    chats.Remove(chat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
