using System;
using System.Collections.Generic;

using System.Globalization;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Planim
{
    class MadrijJson
    {

        [JsonProperty("idMadrij", NullValueHandling = NullValueHandling.Ignore)]
        public long? IdMadrij { get; set; }

        [JsonProperty("Nombre", NullValueHandling = NullValueHandling.Ignore)]
        public string Nombre { get; set; }

        [JsonProperty("idInstitucion", NullValueHandling = NullValueHandling.Ignore)]
        public long? IdInstitucion { get; set; }

        [JsonProperty("Apellido", NullValueHandling = NullValueHandling.Ignore)]
        public string Apellido { get; set; }

        [JsonProperty("Mail", NullValueHandling = NullValueHandling.Ignore)]
        public string Mail { get; set; }

        [JsonProperty("Contrasenia", NullValueHandling = NullValueHandling.Ignore)]
        public string Contrasenia { get; set; }
    }
}
