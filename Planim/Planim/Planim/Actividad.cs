using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Actividad
    {
        [JsonProperty("$id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("idActividad")]
        public long IdActividad { get; set; }

        [JsonProperty("TiempoTotal")]
        public long TiempoTotal { get; set; }

        [JsonProperty("idPuntaje")]
        public long IdPuntaje { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("CantNiñosRecom")]
        public long CantNiñosRecom { get; set; }

        [JsonProperty("EdadRecom")]
        public long EdadRecom { get; set; }

        [JsonProperty("Hiloconductor")]
        public long? Hiloconductor { get; set; }

        [JsonProperty("Cierre")]
        public long? Cierre { get; set; }
    }
}
