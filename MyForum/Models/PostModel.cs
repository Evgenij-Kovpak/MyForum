using System;

namespace FORUM.WEB.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime PostTime { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }


        
    }
}