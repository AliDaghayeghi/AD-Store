using ADStore.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Domain.Entities.HomePages
{
    public class HomePageImages:BaseEntity
    {
        public string Src { get; set; }
        public string link { get; set; }
        public ImageLocation  ImageLocation { get; set; }
    }

    public enum ImageLocation
    {
        L1=0,
        L2=1,
        R1=3,
        CenterFullScreen=4,
        G1=5,
        G2=6,
    }

}
