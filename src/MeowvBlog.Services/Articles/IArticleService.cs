﻿using MeowvBlog.Services.Dto.Articles;
using MeowvBlog.Services.Dto.Articles.Params;
using MeowvBlog.Services.Dto.Common;
using System.Threading.Tasks;
using UPrime;

namespace MeowvBlog.Services.Articles
{
    /// <summary>
    /// 文章服务接口
    /// </summary>
    public partial interface IArticleService
    {
        /// <summary>
        /// 获取一篇文章详细信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ActionOutput<ArticleDto>> GetAsync(int id);

        /// <summary>
        /// 新增文章
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ActionOutput<string>> InsertAsync(InsertArticleInput input);

        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ActionOutput<string>> UpdateAsync(UpdateArticleInput input);

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ActionOutput<string>> DeleteAsync(DeleteInput input);
    }
}