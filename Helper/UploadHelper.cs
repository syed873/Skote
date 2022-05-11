using ImageResizer;
using Skote.Services.Person.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Skote.Helper
{
    public class UploadHelper
    {

        public static string UploadLogo(PersonEditDto image, HttpPostedFileBase logo)
        {
            if (logo != null && logo.ContentLength > 0)
            {
                var filename = $"{DateTime.Now.Ticks.ToString()}{Path.GetExtension(logo.FileName)}";
                var thumbName = filename.Split('.').ElementAt(0) + "_Thumb." + filename.Split('.').ElementAt(1);
                var serverpath = "/Image/";
                var serverpath1 = "/Thumb/";
                bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(serverpath));

                if (!exists)
                    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(serverpath));

                bool existst = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(serverpath1));

                if (!existst)
                    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(serverpath1));
                var path = Path.Combine(HttpContext.Current.Server.MapPath(serverpath), filename);


                var thumbPath = Path.Combine(HttpContext.Current.Server.MapPath(serverpath1), thumbName);
                image.Image = filename;
                logo.SaveAs(path);
                Image img = Image.FromFile(path);
                logo.SaveAs(thumbPath);

                int imgHeight = 100;
                int imgWidth = 100;
                if (img.Width < img.Height)
                {
                    imgHeight = 100;
                    var imgRatio = (float)imgHeight / (float)imgHeight;
                    imgWidth = Convert.ToInt32(imgHeight * imgRatio);
                }
                else if (img.Height < img.Width)
                {
                    //landscape image  
                    imgWidth = 100;
                    var imgRatio = (float)imgWidth / (float)imgWidth;
                    imgHeight = Convert.ToInt32(imgHeight * imgRatio);
                }

                Image thumb = img.GetThumbnailImage(imgWidth, imgHeight, () => false, IntPtr.Zero);
                thumb.Save(thumbPath);


                return $"{serverpath}{filename}";
            }
            else { return null; }
        }

        public static string Thumbnail(HttpPostedFileBase file, string Url)
        {
            if (file != null)
            {
                string filename = Path.GetFileName(file.FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                var path = Url;
                bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(path));

                if (!exists)
                    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(path));
                string filepath = Path.Combine(HttpContext.Current.Server.MapPath(path), _filename);
                file.SaveAs(filepath);

                ResizeSettings resizeSetting = new ResizeSettings
                {
                    Width = 150,
                    Height = 100,
                    Format = "png"
                };
                ImageBuilder.Current.Build(filepath, filepath, resizeSetting);
                return $"{path}{_filename}";
            }
            else { return null; }

        }

        public static string UploadImage(HttpPostedFileBase file, string Url)
        {
            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                string fileExtension = Path.GetExtension(file.FileName);
                var path = Url;
                bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath(path));

                if (!exists)
                    System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(path));
                string filepath = Path.Combine(HttpContext.Current.Server.MapPath(path), _filename);
                file.SaveAs(filepath);
                return $"{path}{_filename}";
            }
            else { return null; }
        }
    }
}