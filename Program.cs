var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/sub/{a}/{b}", (int a, int b) => { return "sum:" + (a - b); } );


app.Run();
