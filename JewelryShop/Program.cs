namespace JewelryShop
{
    public class Program
    {

        //Varf�r fungerar inte min font-family i index.css?

        //Hur �r mitt uppl�gg av klasser och filer? �r det bra eller d�ligt?

        //Beh�vs Services i mitt Razor Pages projekt? 

        //Hur kan jag g�ra s� att mina produkter visas p� sidan?


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

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
