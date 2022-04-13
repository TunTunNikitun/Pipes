using TestTaskForTMK.Models;
namespace TestTaskForTMK
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //Packages pack = new Packages
                //{
                //    PackageNumber = 1,
                //    PackageDate = "01.01.2001"
                //};
                //db.Packages.Add(pack);
                //db.SaveChanges();
                //PackageStructure ps = new PackageStructure
                //{
                //    PackageId = 1,
                //    PipeId = 11
                //};
                //db.PackageStructure.Add(ps);
                //db.SaveChanges();
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}