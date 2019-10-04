using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Planim;


namespace Planim
{
    class APIConexion
    {
        //Traer Instituciones
        public List<Instituciones> GetInstituciones()
        {
            List<Instituciones> returnList = new List<Instituciones>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = "http://10.152.2.31:59449/";
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/instituciones").Result;
                if (response.IsSuccessStatusCode)
                {
                    returnList = response.Content.ReadAsAsync<List<Instituciones>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }


        public List<ClaseJuego> GetJuegos()
        {
            List<ClaseJuego> returnList = new List<ClaseJuego>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = "http://10.152.2.31:59449/";
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/Juegos").Result;
                if (response.IsSuccessStatusCode)
                {
                    returnList =response.Content.ReadAsAsync<List<ClaseJuego>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }

        public List<ClaseJuego> GetJuegosxID(List<int>id)
        {
            List<ClaseJuego> listaJuego = new List<ClaseJuego>(); 
            string strBaseAdressURL;
            HttpResponseMessage response;
            ByteArrayContent byteContent;
            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = "http://10.152.2.31:59449/";
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                byteContent = ObjectToByteArrayContent(id);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.PostAsync("api/Juegos/getbyid",byteContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    listaJuego = response.Content.ReadAsAsync<List<ClaseJuego>>().Result;
                }
                //client.Dispose();
            }

            return listaJuego;
        }
        //Cargar Madrijim
        public Madrijim InsertMadrij(Madrijim newEntity) {
            Madrijim            returnEntity = null;
            string              strBaseAdressURL;
            ByteArrayContent    byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL    = "http://10.152.2.31:59449/";
                client.BaseAddress  = new Uri(strBaseAdressURL);
                
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                

                response = client.PostAsync("api/madrijims",byteContent).Result;
                if (response.IsSuccessStatusCode) {
                    returnEntity = response.Content.ReadAsAsync<Madrijim>().Result;
                } else {
                    returnEntity = new Madrijim();
                }
            }

            return returnEntity;
        }
       
        //Cargar Juego
        public NuevoJuego InsertJuego(NuevoJuego newEntity)
        {
            NuevoJuego returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = "http://10.152.2.31:59449/";
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                response = client.PostAsync("api/Juegos", byteContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    returnEntity = response.Content.ReadAsAsync<NuevoJuego>().Result;
                }
                else
                {
                    returnEntity = new NuevoJuego();
                }
            }

            return returnEntity;
        }

        //Convertir a objeto a Json
        private static ByteArrayContent ObjectToByteArrayContent(object currentObject) {
            ByteArrayContent    returnByteArrayContent;
            string              myContent;
            byte[]              buffer;

            myContent    = JsonConvert.SerializeObject(currentObject);
            buffer       = System.Text.Encoding.UTF8.GetBytes(myContent);
            returnByteArrayContent = new ByteArrayContent(buffer);

            returnByteArrayContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return returnByteArrayContent;
        }
      
        //Traer Madrijim
      /*  public List<MadrijJson> GetMadrijim()
        {
            List<MadrijJson> returnList = new List<MadrijJson>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = "http://10.152.2.31:59449/";
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/madrijims").Result;
                if (response.IsSuccessStatusCode)
                {
                    returnList = response.Content.ReadAsAsync<List<MadrijJson>>().Result;
                }
               // client.Dispose();
            }

            return returnList;
        }*/


    }
}
