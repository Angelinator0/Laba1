var app = Microsoft.AspNetCore.Builder.WebApplication.Create();

app.MapGet("/", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>Добро пожаловать в Minimal API!</h1>");
});

app.MapGet("/about", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>О нас</h1><p>Это простая страница 'О нас'.</p>");
});

app.MapGet("/contact", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>Контакты</h1><p>Свяжитесь с нами: email@example.com</p>");
});

app.Run();

