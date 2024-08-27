namespace EmployeeTrackingSystem
{
    public class Singleton
    {
        private Singleton() { }
        private static NavigationMenu _instance;

        public static void SetInstance(string rol, string id)
        {
            if (_instance == null)
            {
                _instance = new NavigationMenu(rol, id);
            }
        }
        public static NavigationMenu GetInstance()
        {
            return _instance;
        }
    }
}
