using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;


namespace WikiMaps.Models
{
    public class CoordsMapper
    {
        public List<CoordsModel> mapcoords()
        {
            List<CoordsModel> coords = new List<CoordsModel>();
            DBConnectionDAO conn = new DBConnectionDAO();
            //NpgsqlDataReader data = conn.connect(51.508742, -0.120850);
            //data.Read();
            NpgsqlDataReader data = conn.connect();
            while (data.Read())
            {
                CoordsModel coord = new CoordsModel(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString());
                coords.Add(coord);
            }
                return coords;
        }
        public List<CoordsModel> mapcoords(string f)
        {
            List<CoordsModel> coords = new List<CoordsModel>();
            DBConnectionDAO conn = new DBConnectionDAO();
            //NpgsqlDataReader data = conn.connect(51.508742, -0.120850);
            //data.Read();
            NpgsqlDataReader data = conn.connectb();
            while (data.Read())
            {
                CoordsModel coord = new CoordsModel(data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString());
                coords.Add(coord);
            }
            return coords;
        }

    }
}
