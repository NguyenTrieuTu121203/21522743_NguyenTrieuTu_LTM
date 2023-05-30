using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Bai4;

[Serializable]
internal class PageScheme
{
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("per_page")] public int PerPage { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
    [JsonPropertyName("total_pages")] public int TotalPages { get; set; }
    [JsonPropertyName("data")] public List<UserScheme>? Data { get; set; }
}
