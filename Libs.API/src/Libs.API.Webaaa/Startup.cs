using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Steeltoe.Discovery.Client;
//using Steeltoe.Common.HealthChecks;
//using Steeltoe.Management.Endpoint.Info;
//using Steeltoe.Management.Endpoint.Metrics;
//using Steeltoe.Management.Endpoint.Health;

////using Halliburton.App.Core.Interfaces;
using Swashbuckle.AspNetCore.Swagger;
//using Halliburton.App.Web;
//using Steeltoe.CloudFoundry.Connector.Redis;
////using Halliburton.App.Core.Queries;
////using Halliburton.App.Infrastructure.Repositories;
//using AutoMapper;
////using Halliburton.App.Core.Commands;
//using System.Collections.Generic;
////using Halliburton.App.Core.DTO;
////using Halliburton.App.Core.Queries.DMA;
////using Halliburton.App.Core.SharedKernel;
////using Halliburton.App.Core.Services;
////using Halliburton.App.Core.Entities;
////using Halliburton.App.Core.Commands.CasingConfigurationCommands;
////using Halliburton.App.Core.Queries.CasingConfigurationQueries;
////using Halliburton.App.Core.DTO.CasingConfigurationDTO;
////using Halliburton.App.Core.Commands.OpenHoleConfigurationCommands;
////using Halliburton.App.Core.Queries.OpenHoleConfigurationQueries;
////using Halliburton.App.Core.Commands.PlugConfigurationCommands;
////using Halliburton.App.Core.DTO.OpenHoleConfigurationDTO;
////using Halliburton.App.Core.Queries.PlugConfigurationQueries;
////using Halliburton.App.Core.Commands.PerforationConfigurationCommands;
////using Halliburton.App.Core.DTO.PlugConfigurationDTO;
////using Halliburton.App.Core.Queries.PerforationConfigurationQueries;
////using Halliburton.App.Core.DTO.PerforationConfigurationDTO;
////using Halliburton.CPE.Connectors.RedisCore.Infastructure;
////using Halliburton.CPE.Connectors.RedisCore.Core;
////using Halliburton.CPE.Connectors.XFleetRedis.Core;
////using Halliburton.CPE.Connectors.XFleetRedis.Infastructure;
////using Halliburton.CPE.Connectors.TreatmentRedis.Core;
////using Halliburton.CPE.Connectors.TreatmentRedis.Infastructure;
////using Halliburton.CPE.Connectors.CECRedis.Core;
////using Halliburton.CPE.Connectors.CECRedis.Infrastructure;
////using Halliburton.CPE.Connectors.ACERedis.Core;
////using Halliburton.CPE.Connectors.ACERedis.Infrastructure;
////using Halliburton.CPE.Connectors.CECRedis.DTO;
////using Halliburton.CPE.Models.XFleet.Command;
////using Halliburton.CPE.Connectors.PumpScheduleRedis.Core;
////using Halliburton.CPE.Connectors.PumpScheduleRedis.Infrastructure;
////using Halliburton.CPE.Connectors.DASCommanderRedis.Core;
////using Halliburton.CPE.Connectors.DASCommanderRedis.Infrastructure;
////using Halliburton.App.Core.Commands.DasCommanderCommands;
////using Halliburton.App.Core.DTO.DassCommanderDTO;
////using Halliburton.CPE.Connectors.TreatmentSyncRedis.Core;
////using Halliburton.CPE.Connectors.TreatmentSyncRedis.Infrasturcure;
////using Halliburton.App.Core.Queries.SandRamp;
////using Halliburton.CPE.Connectors.XWellSyncRedis.Core;
////using Halliburton.CPE.Connectors.XWellSyncRedis.Infrastructure;
////using Halliburton.CPE.Models.CEC;
////using Halliburton.CPE.Models.Heimdall;
////using Halliburton.CPE.Connectors.HeimdallRedis.Core;
////using Halliburton.CPE.Connectors.HeimdallRedis.Infrastructure;
////using Halliburton.CPE.Connectors.DASCommanderRedis.DTO;
////using Halliburton.App.Core.Queries.DasCommanderQueries;
////using Halliburton.CPE.Connectors.XFleetSync.Core.DTO;
////using Halliburton.CPE.Connectors.XFleetSync.Core;
////using Halliburton.CPE.Connectors.XFleetSync.Infrastructure;
//using MongoDB.Bson;
////using Halliburton.App.Core.Queries.XFleetMgmtQueries;
////using Halliburton.App.Core.DTO.WellInterference;
//using Steeltoe.CloudFoundry.Connector.MongoDb;
//using System;
using Swashbuckle.Swagger;
//using Halliburton.App.Core.Commands.SandRamp;
//using Halliburton.App.Core.Commands.Heimdall;

namespace Halliburton.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string AllowSpecificOrigins = "AllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //// SyncServcie Configs
            //var syncServcieConfigs = new SyncServcieConfigs();
            //Configuration.Bind("SyncServcieConfigs", syncServcieConfigs);
            //services.AddSingleton(syncServcieConfigs);
            //// DasCommanderConfigs Inputs
            //var dasCommanderConfigs = new DasCommanderConfigs();
            //Configuration.Bind("DasCommanderConfigs", dasCommanderConfigs);
            //services.AddSingleton(dasCommanderConfigs);
            //// CEC Inputs
            //var cecInputParameters = new CECInputParameters();
            //Configuration.Bind("CECInputParameters", cecInputParameters);
            //services.AddSingleton(cecInputParameters);
            ////Sandramp
            //var sandRampParameter = new SandRampParameter();
            //Configuration.Bind("SandRampParameter", sandRampParameter);
            //services.AddSingleton(sandRampParameter);
            ////Heimdall Parameter
            //var heimDallParameter = new HeimDallParameter();
            //Configuration.Bind("HeimDallParameter", heimDallParameter);
            //services.AddSingleton(heimDallParameter);
            ////CEC Fluid Types
            //var fluidTypesParameter = new FluidTypesParameter();
            //Configuration.Bind("FluidTypesParameter", fluidTypesParameter);
            //services.AddSingleton(fluidTypesParameter);
            ////bind heimdall config
            //var heimdallKeys = new HeimdallKeys();
            //Configuration.Bind("HeimdallKeys", heimdallKeys);
            //services.AddSingleton(heimdallKeys);
            //// bind sandramp config
            //var sandRampInputModelKeys = new SandRampInputModelKeys();
            //Configuration.Bind("SandRampInputModelKeys", sandRampInputModelKeys);
            //services.AddSingleton(sandRampInputModelKeys);
            //// bind redis config
            //var redis = new Redis();
            //Configuration.Bind("redis", redis);
            //services.AddSingleton(redis);

            //var msServiceInfo = new MSServiceInfo();
            //// bind micro service info
            //Configuration.Bind("msserviceinfo", msServiceInfo);
            //services.AddSingleton(msServiceInfo);
            //// bind Sping Setting info
            //var spring = new Spring();
            //Configuration.Bind("spring", spring);
            //services.AddSingleton(spring);

            //var mongodb = new Mongodb();
            //Configuration.Bind("mongodb", mongodb);
            //services.AddSingleton(mongodb);

            // Add managment endpoint services
            //services.AddCloudFoundryActuators(Configuration, MediaTypeVersion.V2, ActuatorContext.Actuator);
            // Add Steeltoe Discovery Client service
            //services.AddDiscoveryClient(Configuration);
            // Add the Redis distributed cache.

            // We are using the Steeltoe Redis Connector to pickup the CloudFoundry

            // This works like the above, but adds a IConnectionMultiplexer to the container
            //services.AddRedisConnectionMultiplexer(Configuration);

            // Add mongo
            //services.AddMongoClient(Configuration);

            // TODO - register a migrate context task with PCF
            //services.AddTask<MigrateDbContextTask<MyContext>>();

            

            // Register CQRS
            //services.AddScoped<ICommandHandler<InsertPlatformInputCommand>, PlatformInputCommandHandler>();
            //services.AddScoped<ICommandHandler<UpdatePlatformInputModel>, PlatformInputCommandHandler>();
            //services.AddScoped<ICommandHandler<SendXfleetCommand>, PlatformInputCommandHandler>();
            //services.AddScoped<ICommandHandler<PublishRedisCommand>, PlatformInputCommandHandler>();
            //services.AddScoped<ICommandHandler<CreateWellboreProfileCommand>, WellboreProfileCommandHandler>();
            //services.AddScoped<ICommandHandler<ImportWellboreProfileCommand>, ImportWellboreProfileCommandHandler>();
            //services.AddScoped<IQueryHandler<GetWellboreProfileByIdQuery, WellboreProfileDTO>, WellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<GetAllWellboreProfileQuery, IEnumerable<WellboreProfileDTO>>, WellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<RetreiveWellboreProfileQuery, string>, RetreiveWellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<GetCurentWellboreProfileQuery, WIWellboreProfileDTO>, WellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<GetCurentWellboreProfileByIFSWellNameQuery, WIWellboreProfileDTO>, WellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<GetWellboreGeometriesQuery, WIWellboreProfileDTO>, WellboreProfileQueryHandler>();
            //services.AddScoped<IQueryHandler<GetWellTrajectoryQuery, WellTrajectoryDTO>, WellboreProfileQueryHandler>();



            // Base service
            //services.AddScoped<IInitialService, InitialService>();

            // Add management components which collect and forwards metrics to
            // the Cloud Foundry Metrics Forwarder service
            // Remove comments below to enable
            //services.AddMetricsActuator(Configuration);
            //services.AddInfoActuator(Configuration);
            //services.AddHealthActuator(Configuration);

            // services.AddMetricsForwarderExporter(Configuration);
            services.AddAutoMapper();

            // add cors
            services.AddCors(options =>
            {
                options.AddPolicy(AllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(Configuration.GetSection("AllowedHosts")?.Get<string[]>())
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            // Register the Swagger services
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Well Data Manager", Version = "v1" });
                c.DocumentFilter<DocumentFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //Accept All HTTP Request Methods from all origins
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

            // Add management endpoints into pipeline
            //app.UseCloudFoundryActuators(MediaTypeVersion.V2, ActuatorContext.Actuator);

            // Add metrics collection to the app
            app.UseMetricsActuator();
            app.UseHealthActuator();
            app.UseInfoActuator();

            // Start up the metrics forwarder service added above
            // Remove comment below to enable
            // app.UseMetricsExporter();

            // Use the Steeltoe Discovery Client service
            app.UseDiscoveryClient();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger(c => c.RouteTemplate = "swagger/{documentName}/swagger.json");

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Well Data Manager API");
            });

            app.UseMvc();

            BackGroundServiceInitializer.InitBackgroundServices(app?.ApplicationServices).Wait();
            ConsulUtility.CleanUnHealthyServiceInstances(app?.ApplicationServices).Wait();
        }
    }
}