using Carnesia.Domain.CMS.BlogPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Carnesia.Application.CMS.Services.BlogPost
{
    public class BlogPostService : IBlogPost
    {
        private readonly HttpClient _httpClient;
        public BlogPostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task CreateBlogPost(CreateBlogPostDTO BlogPost)
        {
            try
            {
                await _httpClient.PostAsJsonAsync("BlogPost/createblog", BlogPost);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<BlogPostDTO>> GetAllBlogPosts()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<BlogPostDTO>>("BlogPost/getallblog");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<BlogPostDTO> GetBlogPostsById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BlogPostDTO>($"BlogPost/getblogbyId/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task PublishToggle(int id)
        {
            try
            {
                await _httpClient.PostAsync($"BlogPost/Toggle/{id}", null);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
