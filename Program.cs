using Microsoft.AspNetCore.ResponseCompression;
using SeeSharp.Messaging;
using System.IO.Compression;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
    cfg.AddOpenBehavior(typeof(PipelineLoggingBehavior<,>));
});

builder.Services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Fastest;
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyOptions =>
    {
        policyOptions.AllowAnyHeader();
        policyOptions.AllowAnyMethod();
        policyOptions.AllowAnyOrigin();
    });
});

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<GzipCompressionProvider>();
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "image/svg+xml" });
});

builder.Services.AddTransient<IIntegracoesService, IntegracoesService>();
builder.Services.AddTransient<IRabbitMQMessageSender, RabbitMQMessageSender>();

builder.Services.AddHostedService<RabbitMQConsumer>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
