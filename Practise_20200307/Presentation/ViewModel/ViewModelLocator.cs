using DAL.Services;

namespace Presentation.ViewModel
{
    public class ViewModelLocator
    {
        private readonly IStudentService studentService;
        
        public ViewModelLocator()
        {
            // tato cast kodu bude sluzit ako composition root, cize tu je mozne naviazat vsetky zavislosti
            // ja som tu pouzil "Poor Man's Dependency Injection" cize ziadny container
            // realny "Composition Root" vo WPF aplikaciach je "OnStartup" metoda v App.xml, ale vytavarat zavislosti priamo tu je taky dobry trade-off

            // ak by si velmi chcel tak mozes posielat cez Property Injection zavislosti vytvorene v OnStartup metode, ale podla mna netreba, lebo tento objekt sa vytvara iba raz a to po spusteni aplikacie 
            // alebo pouzit staticky container (zavislosti vytvorit v OnStartup a tu iba resolvovat)
            
            this.studentService = new StudentService();
        }

        public StudentViewModel StudentViewModel => new StudentViewModel(studentService);


        // ak chces pri kazdom volani mat novu instanciu servisu tak mozes spravit vytvaranie objektu nasledovne
        //public StudentViewModel StudentViewModel
        //{
        //    get
        //    {
        //        var studentService = new StudentService();
        //        return new StudentViewModel(studentService);
        //    }
        //}
    }
}