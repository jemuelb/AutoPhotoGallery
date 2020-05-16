using AutoPhotoGallery.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace AutoPhotoGallery.Services
{
    public class PhotoService
    {
        private readonly IWebHostEnvironment _env;
        private readonly LinkGenerator _linkGenerator;
        private readonly PhotoListModel pl = new PhotoListModel();
        private readonly string basePath = "images/gallery";

        public PhotoService(IWebHostEnvironment env, LinkGenerator linkGenerator)
        {
            _env = env;
            _linkGenerator = linkGenerator;
        }

        public PhotoListModel GenerateList(string GalleryPath)
        {

            List<string> FileNames = GenerateFileList(GalleryPath);

            pl.PhotoList = x;
            pl.GalleryName = GalleryPath;

            return pl;
        }
        
        private List<string> GenerateFileList(string GalleryPath)
        {
            string ImgPath = Path.Combine(_env.WebRootPath, basePath, GalleryPath);

            List<string> fileNames = new List<string>();

            foreach (string filename in Directory.GetFiles(ImgPath).ToList())
            {
                fileNames.Add(Path.GetFileName(filename));
            }

            return fileNames;
        }

        private List<string> GenerateAbsolutePaths()
        {
            throw new NotImplementedException();
        }

    }
}
