namespace hp_api.data.Schemas
{
    public class UserSchema
    {
        public static string Table { get; } = "Public.user";

        public static class Columns
        {
            public static string Id { get; } = "id";
            public static string UserName { get; } = "user_name";
            public static string FirstName { get; } = "first_name";
            public static string LastName { get; } = "last_name";
            public static string Email { get; } = "email";
            public static string Password { get; } = "password";
            public static string CreatedAt { get; } = "created_at";
        }
    }
}