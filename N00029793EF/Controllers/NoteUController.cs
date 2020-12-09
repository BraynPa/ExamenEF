using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using N00029793EF.Models;

namespace N00029793EF.Controllers
{
    public class NoteUController : Controller
    {
        private readonly N00029793EFContext context;
        public NoteUController(N00029793EFContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.Etiquetas = context.Tages.ToList();
            ViewBag.Etiquetitas = context.TagNotes.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            var tages = context.TagNotes.Include(o => o.note).Include(y => y.Tag).OrderByDescending(x => x.note.Fecha).ToList();
            ViewBag.Etiquetitas = context.TagNotes.ToList();
            ViewBag.Etiquetas = context.Tages.ToList();
            
            if (!String.IsNullOrEmpty(search))
            {
               
                ViewData["Message"] = "Exito";
                tages = tages.Where(o => o.Tag.Nombre.Contains(search) || o.note.Titulo.Contains(search) || o.note.Contenido.Contains(search)).ToList();
                return View(tages);
            }
            return View(tages);
        }
        [HttpGet]
        public IActionResult Natog(int id)
        {
            var tages = context.TagNotes.Include(o => o.note).Include(y => y.Tag).Where(x => x.IdTag == id).OrderByDescending(x => x.note.Fecha).ToList();
            return View(tages);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.Tages.ToList();
            return View(new Note());
        }

        [HttpPost]
        public IActionResult Create(Note note, List<int> tag)
        {
            note.Fecha = DateTime.Now;

            List<TagNote> etica = new List<TagNote>();
            if (tag.Count() == 0)
                ModelState.AddModelError("Etiqueta", "Seleccione uno");

            if (ModelState.IsValid)
            {
                context.Notes.Add(note);
                context.SaveChanges();
                foreach (var item in tag)
                {
                    var etique = new TagNote();
                    etique.IdTag = item;
                    etique.IdNote = note.Id;
                    etica.Add(etique);
                }
                context.TagNotes.AddRange(etica);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Tages.ToList();
                return View(note);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.Tages.ToList();
            var nota = context.Notes.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }

        [HttpPost]
        public IActionResult Edit(Note note)
        {
            note.Fecha = DateTime.Now;


            if (ModelState.IsValid)
            {
                context.Notes.Update(note);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.Tages.ToList();
                return View(note);
            }
        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {

            var etiqueta = context.Tages.ToList();
            ViewBag.Etiquetas = context.TagNotes.Include(o => o.Tag).ToList();
            var nota = context.Notes.Where(o => o.Id == id).FirstOrDefault();
            return View(nota);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            var nota = context.Notes.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.TagNotes.Where(o => o.IdNote == id).ToList();
            context.Notes.Remove(nota);
            context.TagNotes.RemoveRange(etiqueta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
