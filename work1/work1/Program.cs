using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using work1;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stations = Findstation();

            ShowStation(stations);

          //  Console.WriteLine("按下任一鍵進行新增資料庫");
            Console.ReadKey();
          
        }

         public static List<station> Findstation()
        {
            List<station> stations = new List<station>();
            var xml = XElement.Load(@"C:\Users\user\Desktop\work1\airpullet.xml");
            var stationsNode = xml.Descendants("Data").ToList();


            for (int i=0;i<stationsNode.Count();i++) {

                var stationNode = stationsNode[i];

            }

            foreach (var stationNode in stationsNode)
            {
                
            }

            
            stationsNode
                .Where(x => !x.IsEmpty).ToList()
                .ForEach(stationNode =>
                {

                var sitename = stationNode.Element("SiteName").Value.Trim();
                var county = stationNode.Element("County").Value.Trim();
                var psi = stationNode.Element("PSI").Value.Trim();
                var majorpollutant = stationNode.Element("MajorPollutant").Value.Trim();
                var status = stationNode.Element("Status").Value.Trim();
                var so2 = stationNode.Element("SO2").Value.Trim();
                var co = stationNode.Element("CO").Value.Trim();
                var o3 = stationNode.Element("O3").Value.Trim();
                var pm10 = stationNode.Element("PM10").Value.Trim();
                var pm2_5 = stationNode.Element("PM2.5").Value.Trim();
                var no2 = stationNode.Element("NO2").Value.Trim();
                var windspeed = stationNode.Element("WindSpeed").Value.Trim();
                var winddirec = stationNode.Element("WindDirec").Value.Trim();
                var publishtime = stationNode.Element("PublishTime").Value.Trim();
                    station stationData = new station();
                    stationData.SiteName = sitename;
                    stationData.County = county;
                    stationData.PSI = psi;
                    stationData.MajorPollutant = majorpollutant;
                    stationData.Status = status;
                    stationData.SO2 = so2;
                    stationData.CO = co;
                    stationData.O3 = o3;
                    stationData.PM10 = pm10;
                    stationData.PM2_5 = pm2_5;
                    stationData.NO2 = no2;
                    stationData.WindSpeed = windspeed;
                    stationData.WindDirec = winddirec;
                    stationData.PublishTime = publishtime;
                    stationData.creattime = DateTime.Now;
                    stations.Add(stationData);

                });

            

            return stations;
 

        }

        public static void ShowStation(List<station> stations)
        {

            Console.WriteLine(string.Format("共收到{0}筆監測站的資料", stations.Count));
            stations.ForEach(x =>
            {
                Console.WriteLine(string.Format("觀測地點：{0},所在縣市:{1}", x.SiteName, x.County));


            });

            
        }


             

    }
}
