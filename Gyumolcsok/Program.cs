namespace Gyumolcsok
{
    internal static class Program
    {
        public static List<Gyumolcs> gyumolcsokList = new List<Gyumolcs>();
        public static DB database = null;
        public static NyitoForm nyitoForm = null;
        static void Main()
        {
            ApplicationConfiguration.Initialize();

           database = new DB();
           gyumolcsokList = database.GetAllFruits();
           nyitoForm = new NyitoForm();

            Application.Run(nyitoForm);
        }
    }
}