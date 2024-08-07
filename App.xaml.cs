using ControleDgn.Data;
using System.Windows;

namespace ControleDgn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AppDbContext _context;

        public App()
        {
            _context = new AppDbContext();
            DatabaseInitializer initializer = new DatabaseInitializer();
            initializer.InitDb(_context);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _context.Dispose();
            base.OnExit(e);
        }
    }

}
