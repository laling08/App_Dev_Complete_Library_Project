using CompleteLibrary_Project.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CompleteLibrary_Project.Controller.DataAccessibility
{
    /// <summary>
    /// Custon JSON converter for the <see cref="User"/> class to handle deserialization of different user types.
    /// </summary>
    public class UserConverter : JsonConverter<User>
    {
        /// <summary>
        /// Reads and converts a JSON to a <see cref="User"/> object.
        /// </summary>
        /// <param name="reader"> The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">The type to convert (should be <see cref="User").</param>
        /// <param name="options">A <see cref="User"/> object, rither a <see cref="Member"/> or <see cref="Librarian"/>.</see></param>
        /// <returns></returns>
        public override User? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                JsonElement root = doc.RootElement;

                string type = root.GetProperty("type").GetString();
                User user;

                if (type.Equals("Member"))
                {
                    user = JsonSerializer.Deserialize<Member>(root.GetRawText(), options);
                }
                else
                {
                    user = JsonSerializer.Deserialize<Librarian>(root.GetRawText(), options);
                }

                return user;
            }
        }

        /// <summary>
        /// Write a <see cref="User"/> object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonReader"/> to write to.</param>
        /// <param name="value">The <see cref="User"/> object to serialize.</param>
        /// <param name="options">Options for the serializer</param>
        public override void Write(Utf8JsonWriter writer, User value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
