var app = Microsoft.AspNetCore.Builder.WebApplication.Create();

//Главная страница
app.MapGet("/", async (Microsoft.AspNetCore.Http.HttpContext context) => 
{
    // Устанавливаем тип контента ответа, чтобы браузер корректно отобразил HTML и поддержал кириллицу
    context.Response.ContentType = "text/html; charset=utf-8";
    // Асинхронно отправляем HTML-код на клиент
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

