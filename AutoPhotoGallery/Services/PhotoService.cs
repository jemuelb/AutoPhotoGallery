using AutoPhotoGallery.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace AutoPhotoGallery.Services
{   
    public class PhotoService
    {
        private readonly IWebHostEnvironment _env;
        private readonly PhotoListModel pl = new PhotoListModel();
        public PhotoService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public PhotoListModel GenerateList()
        {
            string ImgPath = Path.Combine(_env.WebRootPath, "images");

            List<string> x = new List<string>();

            foreach (string filename in Directory.GetFiles(ImgPath).ToList())
            {
                x.Add(Path.GetFileName(filename));
            }

            pl.PhotoList = x;

            return pl;
        }

    }
}
