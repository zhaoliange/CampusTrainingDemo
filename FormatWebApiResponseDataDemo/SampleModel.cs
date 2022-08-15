using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FormatWebApiResponseDataDemo
{
    public class SampleModel
    {
        [Range(1, 10)]
        //[JsonPropertyName("sampleValue")]
        public int Value { get; set; }
    }
}
