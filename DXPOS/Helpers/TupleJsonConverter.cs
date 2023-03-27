using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DXPOS.Helpers;

public sealed class TupleJsonConverter : JsonConverter
{
    /// <inheritdoc />
    public override bool CanConvert(Type objectType) => typeof(ITuple).IsAssignableFrom(objectType);

    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        if (value is ITuple tpl)
        {
            writer.WriteStartArray();

            for (int i = 0; i < tpl.Length; i++)
            {
                serializer.Serialize(writer, tpl[i]);
            }

            writer.WriteEndArray();
        }
        else
        {
            writer.WriteNull();
        }
    }

    /// <inheritdoc />
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue,
        JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.StartArray)
        {
            var arr = JArray.Load(reader);

            // Tuples have 7 elements max., 8th must be another tuple
            var genericsStack = new Stack<Type[]>();
            var generics = objectType.GetGenericArguments();
            genericsStack.Push(generics);
            while (generics.Length > 7 && typeof(ITuple).IsAssignableFrom(generics[7]))
            {
                generics = generics[7].GetGenericArguments();
                genericsStack.Push(generics);
            }

            // Check generics length against tuple length
            if ((genericsStack.Count - 1) * 7 + genericsStack.Peek().Length != arr.Count)
            {
                // As you can omit tail elements in TypeScript tuples you might do some advanced check here
                // (if fewer elements than generics, are the types of the omitted elements nullable or things like that...).
                throw new JsonSerializationException(
                    "Cannot deserialize Tuple, because the number of elements do not match the specified Tuple type.");
            }

            var argIndex = arr.Count;
            object? value = null;
            // deserialize tuples from inside do outside
            foreach (var chunk in genericsStack)
            {
                var tupleType = GetTupleTypeDefinition(objectType, chunk.Length);

                var args = new object?[chunk.Length];

                if (chunk.Length > 0)
                {
                    // make concrete tuple type
                    tupleType = tupleType.MakeGenericType(chunk);

                    int i = chunk.Length - 1;

                    // append previous tuple as 8th, inner tuple
                    if (i == 7)
                    {
                        args[7] = value;
                        i--;
                    }

                    // deserialize elements
                    for (; i >= 0; i--)
                    {
                        args[i] = arr[--argIndex].ToObject(chunk[i], serializer);
                    }
                }

                // create tuple instance
                value = Activator.CreateInstance(tupleType, args);
            }

            return value;
        }

        throw new JsonSerializationException($"Cannot deserialize token {reader.TokenType} to Tuple.");
    }

    private static Type GetTupleTypeDefinition(Type objectType, int elementCount)
    {
        // ValueTuple<>
        if (objectType.IsValueType)
        {
            return elementCount switch
            {
                8 => typeof(ValueTuple<,,,,,,,>),
                7 => typeof(ValueTuple<,,,,,,>),
                6 => typeof(ValueTuple<,,,,,>),
                5 => typeof(ValueTuple<,,,,>),
                4 => typeof(ValueTuple<,,,>),
                3 => typeof(ValueTuple<,,>),
                2 => typeof(ValueTuple<,>),
                1 => typeof(ValueTuple<>),
                0 => typeof(ValueTuple),
                _ => throw new IndexOutOfRangeException(),
            };
        }

        // Tuple<>
        return elementCount switch
        {
            8 => typeof(Tuple<,,,,,,,>),
            7 => typeof(Tuple<,,,,,,>),
            6 => typeof(Tuple<,,,,,>),
            5 => typeof(Tuple<,,,,>),
            4 => typeof(Tuple<,,,>),
            3 => typeof(Tuple<,,>),
            2 => typeof(Tuple<,>),
            1 => typeof(Tuple<>),
            _ => throw new IndexOutOfRangeException(),
        };
    }
}