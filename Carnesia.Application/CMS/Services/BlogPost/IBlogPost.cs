using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.CMS.BlogPost;

namespace Carnesia.Application.CMS.Services.BlogPost
{
    public interface IBlogPost
    {
        Task CreateBlogPost(CreateBlogPostDTO BlogPost);
        Task<List<BlogPostDTO>> GetAllBlogPosts();
        Task<BlogPostDTO> GetBlogPostsById(int id);
        Task PublishToggle(int id);
    }
}
