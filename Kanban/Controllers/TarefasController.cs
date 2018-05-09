using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kanban.Models;

namespace Kanban.Controllers
{
    public class TarefasController : Controller
    {
        public static List<Tarefa> Tarefas = new List<Tarefa>();

        // GET: Tarefas
        public ActionResult Index()
        {
            List<Tarefa> Afazer = new List<Tarefa>();
            List<Tarefa> Exec = new List<Tarefa>();
            List<Tarefa> Conc = new List<Tarefa>();
            for(int i=0;i<Tarefas.Count;i++)
            {
                if(Tarefas[i].Status==1)
                {
                    Afazer.Add(Tarefas[i]);
                }
                if (Tarefas[i].Status == 2)
                {
                    Exec.Add(Tarefas[i]);
                }
                if (Tarefas[i].Status == 3)
                {
                    Conc.Add(Tarefas[i]);
                }
            };
            ViewBag.Afazer = Afazer;
            ViewBag.Exec = Exec;
            ViewBag.Con = Conc;
            return View();
        }

        // GET: Tarefas/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Tarefa tarefa = db.Tarefas.Find(id);
        //    if (tarefa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tarefa);
        //}

        // GET: Tarefas/Create
        public ActionResult Create()
        {
            return View(Tarefas);
        }

        // POST: Tarefas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Status")] Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                Tarefas.Add(tarefa);
                return RedirectToAction("Index");
            }

            return View(tarefa);
        }

        // GET: Tarefas/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Tarefa tarefa = db.Tarefas.Find(id);
        //    if (tarefa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tarefa);
        //}

        //// POST: Tarefas/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Nome,Status")] Tarefa tarefa)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tarefa).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(tarefa);
        //}

        //// GET: Tarefas/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Tarefa tarefa = db.Tarefas.Find(id);
        //    if (tarefa == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tarefa);
        //}

        //// POST: Tarefas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Tarefa tarefa = db.Tarefas.Find(id);
        //    db.Tarefas.Remove(tarefa);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
     
    }
}
