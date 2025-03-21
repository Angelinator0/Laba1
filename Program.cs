// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Http;

// var app = WebApplication.Create();

// // Главная страница
// app.MapGet("/", async (HttpContext context) =>
// {
//     context.Response.ContentType = "text/html; charset=utf-8";
//     await context.Response.WriteAsync("<h1>Добро пожаловать в Minimal API!</h1>");
// });

// // Вторая страница
// app.MapGet("/about", async (HttpContext context) =>
// {
//     context.Response.ContentType = "text/html; charset=utf-8";
//     await context.Response.WriteAsync("<h1>О нас</h1><p>Это простая страница 'О нас'.</p>");
// });

// // Третья страница
// app.MapGet("/contact", async (HttpContext context) =>
// {
//     context.Response.ContentType = "text/html; charset=utf-8";
//     await context.Response.WriteAsync("<h1>Контакты</h1><p>Свяжитесь с нами: email@example.com</p>");
// });

// // Запуск приложения
// app.Run();



var app = Microsoft.AspNetCore.Builder.WebApplication.Create();

// Главная страница
app.MapGet("/", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>Добро пожаловать в Minimal API!</h1>");
});

// Вторая страница
app.MapGet("/about", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>О нас</h1><p>Это простая страница 'О нас'.</p>");
});

// Третья страница
app.MapGet("/contact", async (Microsoft.AspNetCore.Http.HttpContext context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync("<h1>Контакты</h1><p>Свяжитесь с нами: email@example.com</p>");
});

// Запуск приложения
app.Run();

