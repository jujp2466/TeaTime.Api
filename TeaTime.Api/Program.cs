using System.Data;
using TeaTime.Api.Helper;
using TeaTime.Repository.DbFactory;
using TeaTime.Repository.Interface;
using TeaTime.Repository.Repository;
using TeaTime.Service.Interface;
using TeaTime.Service.Service;

var builder = WebApplication.CreateBuilder(args);

// �[���t�m
builder.Configuration.SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();

// ���U�u�t
builder.Services.AddSingleton<IDbConnectionFactory, SqlServerConnectionFactory>();

// �ϥΤu�t���UIDbConnection
builder.Services.AddScoped<IDbConnection>(provider =>
{
    var factory = provider.GetRequiredService<IDbConnectionFactory>();
    return factory.CreateConnection();
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// �ҥ� CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5173", "https://icy-glacier-0f3eddc0f.5.azurestaticapps.net")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
//�~���޿�
builder.Services.AddScoped<IGetUserInfoService, GetUserInfoService>();
//��Ʀs��
builder.Services.AddScoped<DbConnectionFactoryProvider>();
builder.Services.AddScoped<IGetUserInfoRepository, GetUserInfoRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//Helper
builder.Services.AddScoped<ConnectionStringList>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
