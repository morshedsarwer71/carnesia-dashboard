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

        public async Task<BlogPostUpdateDTO> GetBlogPostsById(int id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<BlogPostUpdateDTO>($"BlogPost/getblogbyId/{id}");
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> PublishToggle(int id)
        {
            try
            {
                var result = await _httpClient.GetAsync($"BlogPost/Toggle/{id}");

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateBlogPost(BlogPostUpdateDTO blog)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync($"BlogPost/updateblog/{blog.id}", blog);

                if (result.IsSuccessStatusCode) return true;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
