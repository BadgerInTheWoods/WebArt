using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    private readonly string _serializationFormat;

    public DateOnlyJsonConverter() : this(null) { }

    public DateOnlyJsonConverter(string? serializationFormat)
    {
        _serializationFormat = serializationFormat ?? "yyyy-MM-dd";
    }

    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        var value = reader.GetString();
        if (value == null || !DateOnly.TryParse(value, out var date))
        {
            throw new JsonException();
        }

        return date;
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(_serializationFormat));
    }
}
