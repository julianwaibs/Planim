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
                strBaseAdressURL = ipconfig();
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

        //Get InstitucionxID
        public Instituciones ObtenerInstitucionxid(int id)
        {
            Instituciones institucion = new Instituciones();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/instituciones/"+id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    institucion =response.Content.ReadAsAsync<Instituciones>().Result;
                }
             
            }

            return institucion;
        }

        //Get Juegos
        public List<ClaseJuego> GetJuegos()
        {
            List<ClaseJuego> returnList = new List<ClaseJuego>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/Juegos").Result;
                if (response.IsSuccessStatusCode)
                {
                    returnList = response.Content.ReadAsAsync<List<ClaseJuego>>().Result;
                }
                //client.Dispose();
            }
            return returnList;
        }

        //Get JuegoxID
        public List<ClaseJuego> GetJuegosxID(List<int>id)
        {
            List<ClaseJuego> listaJuego = new List<ClaseJuego>(); 
            string strBaseAdressURL;
            HttpResponseMessage response;
            ByteArrayContent byteContent;
            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
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

        // Get ActividadxID
        public Actividad GetActividadxid(int id)
        {
            Actividad actividad = new Actividad();
            string strBaseAdressURL;
            HttpResponseMessage response;
            ByteArrayContent byteContent;
            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                byteContent = ObjectToByteArrayContent(id);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.GetAsync("api/actividades/byid?id="+id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    actividad = response.Content.ReadAsAsync<Actividad>().Result;
                }
                //client.Dispose();
            }

            return actividad;
        }
        //Get Actividades x id madrij


        public List<Actividad> GetActividadesxIdMadrij(int id)
        {
            List<Actividad> listaActividad = new List<Actividad>();
            string strBaseAdressURL;
            HttpResponseMessage response;
            ByteArrayContent byteContent;
            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                byteContent = ObjectToByteArrayContent(id);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.GetAsync("api/actividades/getbyidm?id=" + id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    listaActividad = response.Content.ReadAsAsync<List<Actividad>>().Result;
                }
                //client.Dispose();
            }

            return listaActividad;
        }

        //Get Actividades
        public List<Actividad> GetActividades()
        {
            List<Actividad> returnList = new List<Actividad>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/Actividades").Result;
                if (response.IsSuccessStatusCode)
                {
                    returnList = response.Content.ReadAsAsync<List<Actividad>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }

        //Subir Madrijim
        public MadrijJson InsertMadrij(Madrijim newEntity) {
            MadrijJson returnEntity = null;
            string              strBaseAdressURL;
            ByteArrayContent    byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL    = ipconfig();
                client.BaseAddress  = new Uri(strBaseAdressURL);
                
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                

                response = client.PostAsync("api/madrijims",byteContent).Result;
                if (response.IsSuccessStatusCode) {
                    returnEntity = response.Content.ReadAsAsync<MadrijJson>().Result;
                } else {
                    returnEntity = new MadrijJson();
                }
            }

            return returnEntity;
        }

        //Borrar Actividad
        public NuevaActividad BorrarActividad(int id)
        {
            NuevaActividad returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(id);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.GetAsync("api/BActividad?id="+id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    returnEntity = response.Content.ReadAsAsync<NuevaActividad>().Result;
                }
                else
                {
                    returnEntity = new NuevaActividad();
                }
            }

            return returnEntity;
        }

        // Borrar Juego
        public NuevoJuego BorrarJuego(int id)
        {
            NuevoJuego returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(id);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.GetAsync("api/BJuegos?id=" + id.ToString()).Result;
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

        //Subir Juego
        public NuevoJuego InsertJuego(NuevoJuego newEntity)
        {
            NuevoJuego returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
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

        //Subir Actividad
        public NuevaActividad InsertActividad(NuevaActividad newEntity)
        {
            NuevaActividad returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.PostAsync("api/actividades", byteContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    returnEntity = response.Content.ReadAsAsync<NuevaActividad>().Result;
                }
                else
                {
                    returnEntity = new NuevaActividad();
                }
            }

            return returnEntity;
        }
        
        //ipconfig
        public string ipconfig()
        {
            string ip = "http://10.152.2.70:59449/";
            return ip;
        }
        //Modificar
        public NuevaActividad ModificarActividad(NuevaActividad newEntity)
        {
            NuevaActividad returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.PostAsync("api/actividades/MActivi", byteContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    returnEntity = response.Content.ReadAsAsync<NuevaActividad>().Result;
                }
                else
                {
                    returnEntity = new NuevaActividad();
                }
            }

            return returnEntity;
        }
        //Insertar actividad al madrij
        public ActividadxMadrij InsertActividadxid(ActividadxMadrij newEntity)
        {
            ActividadxMadrij returnEntity = null;
            string strBaseAdressURL;
            ByteArrayContent byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                response = client.PostAsync("api/madrijim/link", byteContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    returnEntity = response.Content.ReadAsAsync<ActividadxMadrij>().Result;
                }
                else
                {
                    returnEntity = new ActividadxMadrij();
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
          
        //Traer Madrij
         public MadrijJson GetMadrij(Madrijim newEntity)
        {   
            MadrijJson madrijJson = new MadrijJson();
            string strBaseAdressURL;
            HttpResponseMessage response;
            ByteArrayContent byteContent;
            using (HttpClient client = new HttpClient())
            {
                strBaseAdressURL = ipconfig();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                response = client.PostAsync("api/Madrijims/Login", byteContent).Result;
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                if (response.IsSuccessStatusCode)
                { 
                    madrijJson = response.Content.ReadAsAsync<MadrijJson>().Result;                                                        
                }
               //client.Dispose();
            }
           return madrijJson;
        }

        //Traer Madrijim
        /*  public List<MadrijJson> GetMadrijim()
          {
              List<MadrijJson> returnList = new List<MadrijJson>();
              string strBaseAdressURL;
              HttpResponseMessage response;

              using (HttpClient client = new HttpClient())
              {
                  strBaseAdressURL = ipconfig();
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
