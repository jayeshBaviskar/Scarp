using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap
{
    public class RSS
    {
        String title;
        String link;
        DateTime pudDate;
        String description;


        public string Title { get => title; set => title = value; }
        public string Link { get => link; set => link = value; }
        public DateTime PudDate { get => pudDate; set => pudDate = value; }
        public string Description { get => description; set => description = value; }
    }
}
