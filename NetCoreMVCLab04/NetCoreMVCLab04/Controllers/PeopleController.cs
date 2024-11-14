using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab04.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NetCoreMVCLab04.Controllers
{
    public class PeopleController : Controller
    {
        // GET: PeopleController
        public ActionResult Index()
        {
            var _peoples = DataLocal.GetPeoples();
            return View(_peoples);
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            People model = new People();
            return View(model);
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People model)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                // upload file vào thư mục wwwroot/product
                var files = HttpContext.Request.Form.Files;
                // using System.linq;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    // nhớ tạo thư mục avatar trong thư mục wwwroot/images
                    // using System.Io;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "images/avatar/" + FileName;// gán tên ảnh cho thuộc tính Avatar
                    }
                }
                DataLocal.peoples.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
            //}
            //else
            //{
            //    return View(model);
            //}
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try
            {

                // upload file vào thư mục wwwroot/product
                var files = HttpContext.Request.Form.Files;
                // using System.linq;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    // nhớ tạo thư mục avatar trong thư mục wwwroot/images
                    // using System.Io;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "Avatar/" + FileName;// gán tên ảnh cho thuộc tính Avatar
                    }
                }
                for (int i = 0; i < DataLocal.peoples.Count; i++)
                {
                    if (DataLocal.peoples[i].Id == id)
                    {
                        DataLocal.peoples[i] = model;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }



        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, People model)
        {
            try
            {
                for (int i = 0; i < DataLocal.peoples.Count; i++)
                {
                    if (DataLocal.peoples[i].Id == id)
                    {
                        DataLocal.peoples.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }
    }
}
