using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WikiMaps.Models
{
    public class CoordsModel
    {

        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string url { get; set; }
        public double latReal { get; set; }
        public double lonReal { get; set; }
        public string featureclass { get; set; }
        public string featurecode { get; set; }

        public CoordsModel(string name, string lat, string lon, string featureclass, string featurecode)
        {
            this.name = name;
            //this.url = url;
            this.latReal = Double.Parse(lat);
            this.lonReal = Double.Parse(lon);
            this.featureclass = featureclass;
            this.featurecode = featurecode;


        }




    }
}
