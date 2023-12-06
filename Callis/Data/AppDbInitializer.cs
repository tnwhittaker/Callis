using Callis.Models;

namespace Callis.Data
{
    public class AppDbInitializer
    {
        private readonly ApplicationDbContext _context;

        //Constructor
        public AppDbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //Seeder Method
        public void Seed()
        {
                //If table exists with no values then it creates a list 
                //with the values and saves them in the DB
                if(!_context.TaskStatuses.Any())
                {
                
                   var StatusNames = new List<Models.TaskStatus>()
                   {
                       new Models.TaskStatus()
                       {
                           statusname = "In Progress"
                       },
                       new Models.TaskStatus()
                       {
                           statusname = "Completed"
                       },
                       new Models.TaskStatus()
                       {
                           statusname = "Assistance Needed"
                       },
                       new Models.TaskStatus()
                       {
                           statusname = "Waiting"
                       }
                   };

                    _context.TaskStatuses.AddRange(StatusNames);
                    _context.SaveChanges();
                    
                }

            if (!_context.AccountTypes.Any())
            {

                var AccTypeNames = new List<Models.AccountType>()
                   {
                       new Models.AccountType()
                       {
                           acctype = "Manager"
                       },
                       new Models.AccountType()
                       {
                           acctype = "User"
                       },
                       new Models.AccountType()
                       {
                           acctype = "Admin"
                       }
                
                    };

                _context.AccountTypes.AddRange(AccTypeNames);
                _context.SaveChanges();

            }



        }
    }
}
