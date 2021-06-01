namespace hp_api.data.Schemas
{
    public class UserSchema
    {
        public static string Table => "Public.user";

        public static class Columns
        {
            public static string Id => "id";
            public static string UserName => "user_name";
            public static string FirstName => "first_name";
            public static string LastName => "last_name";
            public static string Email => "email";
            public static string Password => "password";
            public static string CreatedAt => "created_at";
        }
    }
}