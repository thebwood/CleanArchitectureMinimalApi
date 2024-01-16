namespace CleanArchitectureMinimalApi.Api.Endpoints
{
    public static class AddressEndpoints
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/", () => "Hello World!"); // GET request to the root path
            app.MapPost("/users", (User user) => { /* Create a user */ }); // POST request with a User object        }
        }
}
