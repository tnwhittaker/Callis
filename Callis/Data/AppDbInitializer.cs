using Callis.Models;

namespace Callis.Data
{
    public class AppDbInitializer
    {
        private readonly ApplicationDbContext context;

        //Constructor
        public AppDbInitializer(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        //Seeder Method
        public void Seed()
        {
                //If table exists with no values then it creates a list 
                //with the values and saves them in the DB
                if(!context.TaskStatuses.Any())
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

                    context.TaskStatuses.AddRange(StatusNames);
                    context.SaveChanges();
                    
                }


            
        }
    }
}
