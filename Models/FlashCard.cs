using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace FlashCardApi.Models
{
    public class FlashCard
    {
        [JsonPropertyName("CId")]
        [Key]
        public int Id{get;set;}
        [JsonPropertyName("Question")]
        [Required(ErrorMessage = "Question is required.")]
        public string Question{get;set;}
        [JsonPropertyName("Answer")]
        [Required(ErrorMessage = "Answer is required.")]
        public string Answer{get;set;}
        [JsonPropertyName("CreatedBy")]
        public string createdBy {get;set;}
    }
}