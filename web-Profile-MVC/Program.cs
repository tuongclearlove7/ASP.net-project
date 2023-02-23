namespace web_Profile_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Console.WriteLine(builder);//building app


            Console.WriteLine("_______________________________________________________");

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();//build app success

            Console.WriteLine(app);

            Console.WriteLine("_______________________________________________________");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()){

                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }
            

            var direction = app.UseHttpsRedirection();

            var publicFile = app.UseStaticFiles(); // public static file

            var route = app.UseRouting(); //route http

            var author = app.UseAuthorization();

            Console.WriteLine(direction);
            Console.WriteLine(route);
            Console.WriteLine(author);
            Console.WriteLine(publicFile);
            

            Console.WriteLine("_______________________________________________________");

          

            app.MapControllerRoute(
                
                name: "default",
                pattern: "{controller=Home}/{action=homePage}/{id?}");

            app.Run();


            
        }
    }
}