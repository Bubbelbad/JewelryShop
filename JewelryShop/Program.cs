using JewelryShop.Services;

namespace JewelryShop
{
    public class Program
    {
        //Hur är mitt upplägg av klasser och filer? Är det bra eller dåligt?
        //- Vart hämtar jag objekten i JewelryShop från db?
        //- Om jag klickar på en produkt, ska jag skicka params till en annan sida då enklast? 
 

        //Varför fungerar inte min font-family i index.css?

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<HttpRequestSender>(); //Gör en temporär instans av ProductService-klassen,
                                                             //som inte behöver komma ihåg variablerna


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
