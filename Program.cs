var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

//make 2 reqs to see the repro:
//get test/a
//get test/b