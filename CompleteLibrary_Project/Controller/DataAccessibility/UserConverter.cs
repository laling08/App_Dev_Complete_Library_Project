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
    public class UserConverter : JsonConverter<User>
    {
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

        public override void Write(Utf8JsonWriter writer, User value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
