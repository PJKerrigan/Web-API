// System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
// Custom
using August.Models;

namespace August.Controllers
{
    public class ArticlesController : ApiController
    {
        private static IList<Article> _List = new List<Article>()
        {
            new Article() { Id = 123, Author = "Jack Kerouac", Body = "Hello, World! This is the first article." },
            new Article() { Id = 124, Author = "Neal Cassady", Body = "Oh, this is the second short article!" },
            new Article() { Id = 125 , Author = "Sal Paradise", Body = "I've travelled around the world, but I didn't find what I wanted." }
        };

        /// <summary>
        /// Gets all articles.
        /// </summary>
        /// <returns>IList of articles.</returns>
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return _List;
        }

        /// <summary>
        /// Gets the article with the specific Id number, if it exists.
        /// </summary>
        /// <param name="id">Id number of the article to get.</param>
        /// <returns>The appropriate article.</returns>
        [HttpGet]
        public Article Get(int id)
        {
            return _List.First(a => a.Id == id);
        }

        /// <summary>
        /// Creates a new article.
        /// </summary>
        /// <param name="article">Article data to use.</param>
        [HttpPost]
        public void Post(Article article)
        {
            int maxId = _List.Max(a => a.Id);
            article.Id = maxId + 1;
            _List.Add(article);
        }

        /// <summary>
        /// Update an article.
        /// </summary>
        /// <param name="id">Id number of the article to update.</param>
        /// <param name="article">Article data to replace the current entry with.</param>
        [HttpPut]
        public void Put(int id, Article article)
        {
            int index = _List.ToList().FindIndex(a => a.Id == id);
            _List[index] = article;
        }

        /// <summary>
        /// Delete an article.
        /// </summary>
        /// <param name="id">Id number of the article to delete.</param>
        [HttpDelete]
        public void Delete(int id)
        {
            Article article = Get(id);
            _List.Remove(article);
        }
    }
}
