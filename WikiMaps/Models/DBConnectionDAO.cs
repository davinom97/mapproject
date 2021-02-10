using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;


namespace WikiMaps.Models
{
    public class DBConnectionDAO
    {

        public NpgsqlDataReader connect()
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Server=localhost;User Id=postgres; " +
                "Password=sqawv334;Database=Map_Coords;");
            npgsqlConnection.Open();


            //NpgsqlCommand command = new NpgsqlCommand("SELECT crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode FROM coords as crds full outer join features as ftr on crds.id=ftr.coordid where id<5000 limit 50",
            //   npgsqlConnection);

            NpgsqlCommand command = new NpgsqlCommand("select crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode from (select * from coords where CAST(lat AS NUMERIC)<44 and CAST(lat AS NUMERIC)>40 and CAST(lng AS NUMERIC)<-69 and CAST(lng AS NUMERIC)>-73) as crds full outer join featuresusa as ftr on crds.id=ftr.coordid limit 25", npgsqlConnection);

            NpgsqlDataReader dr = command.ExecuteReader();

            return dr;
            //return dr[1].ToString();
        }

        public NpgsqlDataReader connectb()
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Server=localhost;User Id=postgres; " +
                "Password=sqawv334;Database=Map_Coords;");
            npgsqlConnection.Open();


            //NpgsqlCommand command = new NpgsqlCommand("SELECT crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode FROM coords as crds full outer join features as ftr on crds.id=ftr.coordid where id<5000 limit 50",
            //   npgsqlConnection);

            NpgsqlCommand command = new NpgsqlCommand("SELECT crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode FROM coords as crds full outer join features as ftr on crds.id=ftr.coordid where crds.lat<52 and crds.lat>50 and crds.lng<52 and crds.lng>50 limit 50", npgsqlConnection);

            NpgsqlDataReader dr = command.ExecuteReader();

            return dr;
            //return dr[1].ToString();
        }
        public NpgsqlDataReader connect(double lat, double lon)
        {
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection("Server=localhost;User Id=postgres; " +
                "Password=sqawv334;Database=Map_Coords;");
            npgsqlConnection.Open();


            //NpgsqlCommand command = new NpgsqlCommand("SELECT crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode FROM coords as crds full outer join features as ftr on crds.id=ftr.coordid where sqrt(((lat-(@(lat)))*(lat-(@(lat)))+(lng-(@(lng)))*(lng-(@(lng)))))<1 limit 50", 
            //   npgsqlConnection);
            NpgsqlCommand command = new NpgsqlCommand("SELECT crds.name, crds.lat, crds.lng, ftr.featureclass, ftr.featurecode FROM coords as crds full outer join features as ftr on crds.id=ftr.coordid where crds.lat<(@(lat))+1 and crds.lat>(@(lat))-1 and crds.lng<(@(lng))+1 and crds.lng>(@(lng))-1 limit 50", npgsqlConnection);
            command.Parameters.AddWithValue("lat", lat);
            command.Parameters.AddWithValue("lng", lon);

            NpgsqlDataReader dr = command.ExecuteReader();

            return dr;
            //return dr[1].ToString();
        }


    }
}
