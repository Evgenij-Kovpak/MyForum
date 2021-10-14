using FORUM.BLL.Infrastructure;
using System.Threading.Tasks;
using FORUM.BLL.DTO;
using System.Collections.Generic;

namespace FORUM.BLL.Interfaces
{
    public interface IPostService
    {
        OperationDetails Create(PostDTO postDto);
        Task<OperationDetails> Delete(PostDTO postDto);
        IEnumerable<PostDTO> GetPostsOfTopic(int topicId);
        PostDTO GetById(int postId);
        void Dispose();
    }
}
