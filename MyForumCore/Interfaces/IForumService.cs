using System.Collections.Generic;
using System.Threading.Tasks;
using FORUM.BLL.DTO;
using FORUM.BLL.Infrastructure;

namespace FORUM.BLL.Interfaces
{
    public interface IForumService
    {
        IEnumerable<ForumDTO> GetAll();
        ForumDTO GetById(int id);
        OperationDetails Create(ForumDTO forumDto);
        Task<OperationDetails> Delete(ForumDTO forumDto);
        OperationDetails UpdateForum(ForumDTO forumDto);
        void Dispose();

    }
}
