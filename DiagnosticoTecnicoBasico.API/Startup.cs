using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace DiagnosticoTecnicoBasico.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Configuracion para evitar CaseSensitive en los Json que retornan los Controllers
            services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            //services.AddMvc().AddNewtonsoftJson();

            //Configuracion del servicio Swagger
            services.AddSwaggerGen(config => config.SwaggerDoc("V1", new OpenApiInfo()
            {
                Title = "Diagnóstico Técnico Básico",
                Version = "1.0.0",
                //Description = "## API Service Test Management para uso interno TECO basada en el estándar TMF653 Release 18.5 - December 2018\n\n### Changelog V5.0.0\n- Breaking change -> Se cambia el error de ErrorAcceptingNote para que el código sea string.\n- Se renombra atributo summaryCodes a summaryCode en ServiceTestTeco para seguir  la convención\n\n### Changelog V4.3.0\n- Se agregan summaryCode y verCode a ServiceTestTeco para soportar el diagnóstico de líneas POTS\n- Se agregan ejemplos para el soporte de la operación TST-FULL de puerto\n- Se agrega a la lista de servidores la URL de service-test-api en estomba y pacheco no productivos\n\n### Changelog V4.2.1\n- El lado listener de la notificación de AttributeValueChanged ahora espera un ServiceTestTeco\n\n### Changelog V4.2.0\n- El verbo PATCH de serviceTest ahora espera una entidad ServiceTestTeco para admitir el campo extendido nota.\n- El verbo PATCH ahora retorna ServiceTestTeco\n- Se quitan operaciones que no están en roadmap\n- Se modifica comentario de release... Se entiende que la versión actual es la que figura en la metadata version\n\n### Changelog V4.1.1\n- Se agrega header X-Requesting-ProcessId en /ServiceTest\n- Se agrega header X-Requesting-Async en /ServiceTest\n\n### Changelog V4.1.0\n- Se agrega PuertoFisicoXDSL\n\n### Changelog V4.0.2\n- Se agrega ServiceTestTeco implementando ServiceTest y agregando el campo note\n- Se agrega ErrorAcceptingNote que hereda de Note y admite contener un objeto tipo Error\n- Se modifica el post de /serviceTest para que devuelva un objeto del tipo ServiceTestTeco\n- Se agregan servers apuntando a nuestros ambientes\n\n### Changelog V4.0.1\n- Se incluyó un ejemplo de invocación a la operación serviceTest con los campos necesarios para solicitar una consulta sobre un puerto lógico GPON\n- Se incluyeron los componentes de otras APIs TMF para lograr un documento autocontenido que pueda resolver la prueba de servicios TECO  - Note  - Service\n  - PartyRole \n  - Place\n  - Resource\n  - ResourceCharacteristic\n  - PhysicalResource\n  - LogicalResource\n\n### Changelog V4.0.0\n- Se descarga la versión original TMF homónima (V4.0.0)\n\n## Descripción original\nService Test Management API goal is to provide the ability to manage tests of provisioned Services.\n\n### Resource\n- ServiceTest\n- ServiceTestSpecification\n\n### Operations\nService Test Management API performs the following operations on the resources\n- Retrieve an entity or a collection of entities depending on filter criteria\n- Partial update of an entity (including updating rules)\n- Create an entity (including default values and creation rules)\n- Delete an entity (for administration purposes)\n- Manage notification of events",
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(config =>
                config.SwaggerEndpoint("/swagger/V1/swagger.json", "Diagnóstico Técnico Básico")
            );
        }
    }
}
