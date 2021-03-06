using System;
using FORUM.BLL.Interfaces;
using FORUM.DAL.Interfaces;

namespace FORUM.BLL.Services
{
    public class ServiceBag : IServiceBag
    {
        IUnitOfWork unitOfWork;

        public ServiceBag(IUnitOfWork UnitOfWork)
        {
            unitOfWork = UnitOfWork;
        }

        public IForumService ForumService
        {
            get
            {
                return new ForumService(unitOfWork);
            }
        }

        public ITopicService TopicService
        {
            get
            {
                return new TopicService(unitOfWork);
            }
        }

        public IPostService PostService
        {
            get
            {
                return new PostService(unitOfWork);
            }
        }

        public IUserService UserService
        {
            get
            {
                return new UserService(unitOfWork);
            }
        }

        public IUserProfileService UserProfileService
        {
            get
            {
                return new UserProfileService(unitOfWork);
            }
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
