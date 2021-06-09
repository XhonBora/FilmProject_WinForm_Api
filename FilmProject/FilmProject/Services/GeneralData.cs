using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FilmProject.DTO;
using Newtonsoft.Json;

namespace FilmProject.Services
{
    public class GeneralData
    {
        public static async Task<List<ListDataDTO>> GetProductsFromConnection()
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/ListData/GetListData");
                string res = "";
                using (var content = response.Content)
                {
                    res = await content.ReadAsStringAsync();
                    JsonSerializer serializer = new JsonSerializer();
                    List<ListDataDTO> dataList = JsonConvert.DeserializeObject<List<ListDataDTO>>(res);
                    return dataList;
                }
            }
        }

        public static async Task<List<ListDataDTO>> GetProductsByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/ListData/GetListDataByName?name="+name+"");
                string res = "";
                using (var content = response.Content)
                {
                    res = await content.ReadAsStringAsync();
                    JsonSerializer serializer = new JsonSerializer();
                    List<ListDataDTO> dataList = JsonConvert.DeserializeObject<List<ListDataDTO>>(res);
                    return dataList;
                }
            }
        }

        public static async Task<ListDataDTO> PostProductsFromConnection(ListDataDTO dto)
        {           
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/");
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                ListDataDTO dataDTO = new ListDataDTO();
                dataDTO.EmriFilmit = dto.EmriFilmit;
                dataDTO.EmriRegjisorit = dto.EmriRegjisorit;
                dataDTO.DataProdhimit = dto.DataProdhimit;
                dataDTO.Minutat = dto.Minutat;
                dataDTO.Vleresimi = dto.Vleresimi;
                dataDTO.Shqiptar = dto.Shqiptar;
                dataDTO.Kategoria = dto.Kategoria;
                dataDTO.Buxheti = dto.Buxheti;
                dataDTO.Invalidated = dto.Invalidated;
                string jsonObject = JsonConvert.SerializeObject(dataDTO);
                var stringContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("api/ListData/PostProducts", stringContent);
                string res = "";
                using (var content = response.Content)
                {
                    res = await content.ReadAsStringAsync();
                    JsonSerializer serializer = new JsonSerializer();
                    ListDataDTO dataList = JsonConvert.DeserializeObject<ListDataDTO>(res);
                    return dataList;
                }
            }
        }

        public static async Task<ListDataDTO> UpdateAllProducts(ListDataDTO dto)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/");
                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                ListDataDTO dataDTO = new ListDataDTO();
                dataDTO.Id = dto.Id;
                dataDTO.EmriFilmit = dto.EmriFilmit;
                dataDTO.EmriRegjisorit = dto.EmriRegjisorit;
                dataDTO.DataProdhimit = dto.DataProdhimit;
                dataDTO.Minutat = dto.Minutat;
                dataDTO.Vleresimi = dto.Vleresimi;
                dataDTO.Shqiptar = dto.Shqiptar;
                dataDTO.Kategoria = dto.Kategoria;
                dataDTO.Buxheti = dto.Buxheti;
                dataDTO.Invalidated = dto.Invalidated;
                string jsonObject = JsonConvert.SerializeObject(dataDTO);
                var stringContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync("api/ListData/UpdateProducts?dto=" + dto + "", stringContent);
                string res = "";
                using (var content = response.Content)
                {
                    res = await content.ReadAsStringAsync();
                    JsonSerializer serializer = new JsonSerializer();
                    ListDataDTO dataList = JsonConvert.DeserializeObject<ListDataDTO>(res);
                    return dataList;
                }
            }
        }
        public static async Task<ListDataDTO> DeleteAllProducts(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.DeleteAsync("api/ListData/DeleteProducts?id=" + id + "");
                string res = "";
                using (var content = response.Content)
                {
                    res = await content.ReadAsStringAsync();
                    JsonSerializer serializer = new JsonSerializer();
                    ListDataDTO dataList = JsonConvert.DeserializeObject<ListDataDTO>(res);
                    return dataList;
                }
            }
        }



    }
}
