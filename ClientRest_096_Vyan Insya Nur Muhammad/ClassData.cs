using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest_096_Vyan_Insya_Nur_Muhammad
{
    class ClassData
    {
        string baseUrl = "http://localhost:1999/";

        public List<Mahasiswa> getAllData()
        {
            List<Mahasiswa> data = new List<Mahasiswa>();
            try
            {
                var json = new WebClient().DownloadString("http://localhost:1999/Mahasiswa");
                data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }


            return data;
        }

        public Mahasiswa getDatabyNIM(string nim)
        {
            Mahasiswa data = new Mahasiswa();
            try
            {
                var json = new WebClient().DownloadString("http://localhost:1999/Mahasiswa/nim=" + nim);
                data = JsonConvert.DeserializeObject<Mahasiswa>(json);
            } catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            return data;

        }

        public string createData(Mahasiswa mhs)
        {
            string msg = "Sukses";
            try
            {
                var data = JsonConvert.SerializeObject(mhs); //Convert to Json
                var postData = new WebClient();
                postData.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                string response = postData.UploadString(baseUrl + "Mahasiswa", data);

            } catch (Exception er)
            {
                msg = "Gagal";
                Console.WriteLine(er);
                Console.ReadLine();

            }
            

            return msg;
        }

        public string updateData(Mahasiswa mhs)
        {
            string msg = "Sukses";
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("UpdateMahasiswaByNIM", Method.PUT);
                request.AddJsonBody(mhs);
                client.Execute(request);
            }
            catch (Exception er)
            {
                msg = "Gagal";
                Console.WriteLine(er);
                Console.ReadLine();

            }


            return msg;
        }

        public string deleteData(string nim)
        {
            string msg = "Sukses";
            try
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest("DeleteMahasiswa/" + nim, Method.DELETE);
                client.Execute(request);

            }
            catch (Exception er)
            {
                msg = "Gagal";
                Console.WriteLine(er);
                Console.ReadLine();

            }


            return msg;
        }
        public string sumData()
        {
            string sum = "";
            try
            {
                var json = new WebClient().DownloadString("http://localhost:1999/Mahasiswa");
                var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
                int i = data.Count();
                sum = i.ToString();
            } catch(Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
           
            return sum;
        }


    }
}
