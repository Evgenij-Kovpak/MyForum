using System;

namespace FORUM.BLL.Interfaces
{
    public interface IServiceBag : IDisposable
    {
        IForumService ForumService { get; }
        ITopicService TopicService { get; }
        IPostService PostService { get; }
        IUserService UserService { get; }
        IUserProfileService UserProfileService { get; }
    }
}
