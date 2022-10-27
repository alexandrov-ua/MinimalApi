var app = WebApplication.Create(args);
app.MapGet("/hello", () => "Hello World!");
app.Run();

