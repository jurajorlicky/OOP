using System;
using System.Collections.Generic;
using System.Text;

namespace ulohaoop
{
    class mostactive
    {
        public static void mostuser(socialsite site1, socialsite site2, socialsite site3, socialsite site4)
        {
        if (site1.AllUsers > site2.AllUsers && site1.AllUsers > site3.AllUsers && site1.AllUsers > site4.AllUsers)   
            Console.WriteLine($"Najviac používana sociálna sieť je {site1.Name}");
        if (site2.AllUsers > site1.AllUsers && site2.AllUsers > site3.AllUsers && site2.AllUsers > site4.AllUsers)   
                Console.WriteLine($"Najviac používana sociálna sieť je {site2.Name}");
        if (site3.AllUsers > site1.AllUsers && site3.AllUsers > site2.AllUsers && site3.AllUsers > site4.AllUsers)
                Console.WriteLine($"Najviac používana sociálna sieť je {site3.Name}");
        if (site4.AllUsers > site1.AllUsers && site4.AllUsers > site2.AllUsers && site4.AllUsers > site3.AllUsers)
                Console.WriteLine($"Najviac používana sociálna sieť je {site4.Name}");
        }
        public static void mostactiv(socialsite site1, socialsite site2, socialsite site3, socialsite site4)
        {
        if (site1.ActiveUsers > site2.ActiveUsers && site1.ActiveUsers > site3.ActiveUsers && site1.ActiveUsers > site4.ActiveUsers)
           Console.WriteLine($"Najviac aktívna sociálna sieť je {site1.Name}");
        if (site2.ActiveUsers > site1.ActiveUsers && site2.ActiveUsers > site3.ActiveUsers && site2.ActiveUsers > site4.ActiveUsers)
           Console.WriteLine($"Najviac aktívna sociálna sieť je {site2.Name}");  
        if (site3.ActiveUsers > site1.ActiveUsers && site3.ActiveUsers > site2.ActiveUsers && site3.ActiveUsers > site4.ActiveUsers)
           Console.WriteLine($"Najviac aktívna sociálna sieť je {site3.Name}");          
        if (site4.ActiveUsers > site1.ActiveUsers && site4.ActiveUsers > site2.ActiveUsers && site4.ActiveUsers > site3.ActiveUsers)
           Console.WriteLine($"Najviac aktívna sociálna sieť je {site4.Name}");
        }

    }
}
