using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPhotoGallery.Models
{
    public class PhotoListModel
    {
        public List<string> PhotoList { get; set; }
        public string BaseDirectory { get; private set; }

        public PhotoListModel()
        {
            BaseDirectory = @"~/images";
        }
    }
}