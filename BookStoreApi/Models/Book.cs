using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    [JsonPropertyName("Name")]
    
    [StringLength(100, MinimumLength = 2)]
    
    [Required]
    public string BookName { get; set; } = null!;
    
    public decimal? Price { get; set; } = null!;

    [StringLength(100, MinimumLength = 2)]
    public string Category { get; set; } = null!;
    
    public string Author { get; set; } = null!;
}