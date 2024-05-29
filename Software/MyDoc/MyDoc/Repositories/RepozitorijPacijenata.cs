using DBLayer;
using MyDoc.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDoc.Repositories
{
    public class RepozitorijPacijenata
    {
        public static Pacijent GetPacijenta(string username)
        {
            string sql = $"SELECT * FROM Pacijent WHERE Username ='{username}'";
            return FetchPacijent(sql);
        }
        public static Pacijent GetPacijenta(int id)
        {
            string sql = $"SELECT * FROM Pacijent WHERE Id = {id}";
            return FetchPacijent(sql);
        }
        private static Pacijent FetchPacijent(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Pacijent pacijent = null;
            if (reader.HasRows == true)
            {
                reader.Read();
                pacijent = KreirajObjekt(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return pacijent;
        }
        private static Pacijent KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();
            var pacijent = new Pacijent
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Username = username,
                Password = password
            };
            return pacijent;
        }
        public static Zahtjev DohvatiZahtjev(int id)
        {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjev WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }

        public static List<Zahtjev> DohvatiZahtjevString(string vrijemetermina)
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = $"SELECT * FROM Zahtjev WHERE VrijemeTermina LIKE '%{vrijemetermina}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }



        public static List<Zahtjev> DohvatiZahtjeve()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string vrijemetermina = reader["VrijemeTermina"].ToString();
            string obrazlozenje = reader["Obrazloženje"].ToString();
            string mogucnostvideopoziva = reader["MogučnostVideopoziva"].ToString();
            int idp = int.Parse(reader["IDPacijent"].ToString());
            var zahtjev = new Zahtjev
            {
                ID = id,
                VrijemeTermina = vrijemetermina,
                Obrazloženje = obrazlozenje,
                MogučnostVideopoziva = mogucnostvideopoziva,
                IDPacijent = idp
            };
            return zahtjev;
        }


        public static void SpremiZahtjev(Zahtjev zahtjev)
        {
            string sql = $"INSERT INTO Zahtjev (VrijemeTermina, Obrazloženje, MogučnostVideopoziva, IDPacijent) VALUES ('{zahtjev.VrijemeTermina}', '{zahtjev.Obrazloženje}', '{zahtjev.MogučnostVideopoziva}', '{zahtjev.IDPacijent}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UrediZahtjev(Zahtjev zahtjev, int id)
        {
            string sql = $"UPDATE Zahtjev SET Obrazloženje= '{zahtjev.Obrazloženje}', VrijemeTermina= '{zahtjev.VrijemeTermina}', MogučnostVideopoziva= '{zahtjev.MogučnostVideopoziva}', IDPacijent = {zahtjev.IDPacijent} WHERE Id= {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
