using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models;

public class PresensiHarianGuru
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    [JsonPropertyName("Name")]
    
    [StringLength(100, MinimumLength = 2)]
    
    [Required]
    public string NIP { get; set; } = null!;
    public string Tgl { get; set; } = null!;
    public string Kehadiran { get; set; } = null!;
}