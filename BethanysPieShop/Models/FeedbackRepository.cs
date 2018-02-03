namespace BethanysPieShop.Models
{
    public class FeedbackRepository:IFeedbackRepository
    {
        private readonly AppDBContext _appDbContext;

        public FeedbackRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }
    }
}