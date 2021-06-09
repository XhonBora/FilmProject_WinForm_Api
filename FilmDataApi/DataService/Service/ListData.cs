using DataService.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Service
{
    public class ListData
    {
        public static List<ListDataDTO> GetListData(string constring)
        {
            List<ListDataDTO> dataProducts = new List<ListDataDTO>();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, EmriFilmit,EmriRegjisorit,DataProdhimit,Minutat,Vleresimi,Shqiptar,Kategoria,Buxheti,Invalidated FROM FilmTable where Invalidated = 20", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            List<object[]> prods = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                            foreach (var prod in prods)
                            {
                                ListDataDTO prd = new ListDataDTO
                                {
                                    Id = (int)prod[0],
                                    EmriFilmit = prod[1] == DBNull.Value ? "" : (string)prod[1],
                                    EmriRegjisorit = prod[2] == DBNull.Value ? "" : (string)prod[2],
                                    DataProdhimit = prod[3] == DBNull.Value ? null : (DateTime)prod[3],
                                    Minutat = prod[4] == DBNull.Value ? null : (int)prod[4],
                                    Vleresimi = prod[5] == DBNull.Value ? "" : (string)prod[5],
                                    Shqiptar = prod[6] == DBNull.Value ? "" : (string)prod[6],
                                    Kategoria = prod[7] == DBNull.Value ? "" : (string)prod[7],
                                    Buxheti = prod[8] == DBNull.Value ? null : (int)prod[8],
                                    Invalidated = prod[9] == DBNull.Value ? null : (int)prod[9]
                                };
                                dataProducts.Add(prd);
                            }
                        }
                    }
                }
            }
            return dataProducts;
        }

        public static List<ListDataDTO> GetListDataFromName(string name, string constring)
        {
            List<ListDataDTO> dataProducts = new List<ListDataDTO>();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand($@"Select Id, EmriFilmit,EmriRegjisorit,DataProdhimit,Minutat,Vleresimi,Shqiptar,Kategoria,Buxheti,Invalidated from FilmTable where Invalidated = 20 and EmriFilmit = '"+name+"'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using(SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            List<object[]> prods = dt.AsEnumerable().Select(n => n.ItemArray).ToList();
                            foreach (var prod in prods)
                            {
                                ListDataDTO prd = new ListDataDTO
                                {
                                    Id = (int)prod[0],
                                    EmriFilmit = prod[1] == DBNull.Value ? "" : (string)prod[1],
                                    EmriRegjisorit = prod[2] == DBNull.Value ? "" : (string)prod[2],
                                    DataProdhimit = prod[3] == DBNull.Value ? null : (DateTime)prod[3],
                                    Minutat = prod[4] == DBNull.Value ? null : (int)prod[4],
                                    Vleresimi = prod[5] == DBNull.Value ? "" : (string)prod[5],
                                    Shqiptar = prod[6] == DBNull.Value ? "" : (string)prod[6],
                                    Kategoria = prod[7] == DBNull.Value ? "" : (string)prod[7],
                                    Buxheti = prod[8] == DBNull.Value ? null : (int)prod[8],
                                    Invalidated = prod[9] == DBNull.Value ? null : (int)prod[9]
                                };
                                dataProducts.Add(prd);
                            }
                        }
                    }
                }
            }
            return dataProducts;
        }

        public static void PostProducts(ListDataDTO dto, string constring)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Insert into FilmTable values (@EmriFilmit," +
                "@EmriRegjisorit, @DataProdhimit, @Minutat, @Vleresimi, @Shqiptar, @Kategoria, @Buxheti, @Invalidated)", con);

            //cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.Parameters.AddWithValue("@EmriFilmit", dto.EmriFilmit);
            cmd.Parameters.AddWithValue("@EmriRegjisorit", dto.EmriRegjisorit);
            cmd.Parameters.AddWithValue("@DataProdhimit", dto.DataProdhimit);
            cmd.Parameters.AddWithValue("@Minutat", dto.Minutat);
            cmd.Parameters.AddWithValue("@Vleresimi", dto.Vleresimi);
            cmd.Parameters.AddWithValue("@Shqiptar", dto.Shqiptar);
            cmd.Parameters.AddWithValue("@Kategoria", dto.Kategoria);
            cmd.Parameters.AddWithValue("@Buxheti", dto.Buxheti);
            cmd.Parameters.AddWithValue("@Invalidated", 20);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void UpdateProducts(ListDataDTO dto, string constring)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Update FilmTable Set EmriFilmit=@EmriFilmit,EmriRegjisorit=@EmriRegjisorit," +
                            "DataProdhimit=@DataProdhimit,Minutat=@Minutat,Vleresimi=@Vleresimi,Shqiptar=@Shqiptar,Kategoria=@Kategoria,Buxheti=@Buxheti where Id = '"+dto.Id+"'", con);

            cmd.Parameters.AddWithValue("@Id", dto.Id);
            cmd.Parameters.AddWithValue("@EmriFilmit", dto.EmriFilmit);
            cmd.Parameters.AddWithValue("@EmriRegjisorit", dto.EmriRegjisorit);
            cmd.Parameters.AddWithValue("@DataProdhimit", dto.DataProdhimit);
            cmd.Parameters.AddWithValue("@Minutat", dto.Minutat);
            cmd.Parameters.AddWithValue("@Vleresimi", dto.Vleresimi);
            cmd.Parameters.AddWithValue("@Shqiptar", dto.Shqiptar);
            cmd.Parameters.AddWithValue("@Kategoria", dto.Kategoria);
            cmd.Parameters.AddWithValue("@Buxheti", dto.Buxheti);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeleteProducts(int id, string constring)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update FilmTable set Invalidated = 10 where Id='" + id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
