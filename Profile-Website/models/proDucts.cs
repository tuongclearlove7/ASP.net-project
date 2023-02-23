using System.Text.Json;
using System.Text.Json.Serialization;

namespace Profile_Website.models
{
    public class proDucts
    {
        public string id { get; set; }
        
        [JsonPropertyName("image")]        
       
        public string image { get; set; }

        public string url { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public int[] raTings { get; set;}

        public override string ToString() 
            
            => JsonSerializer.Serialize<proDucts>(this);
      

            
    }
}

