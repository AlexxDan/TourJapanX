using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.Helper;

namespace TourJapanX.Repository
{
    public class RepositoriesTourJapan
    {
        HelperFile helper;

        public RepositoriesTourJapan()
        {
            this.helper = new HelperFile();
        }
        /*public List<Series> GetSeries()
        {
            String resource = "XamarinDatosLocales.Documents.series.json";
            String data = this.helper.ReadFIle(resource);

            List<Series> series = JsonConvert.DeserializeObject<List<Series>>(data);
            return series;

        }*/


    }
}
