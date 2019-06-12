using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieDen.Models
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private readonly DatabaseContext _dbContext;
        public FeedbackRepository(DatabaseContext context)
        {
            _dbContext = context;
        }
        public void AddFeedback(Feedback feedback)
        {
            _dbContext.Feedbacks.Add(feedback);
            _dbContext.SaveChanges();
        }
    }
}
