using Microsoft.EntityFrameworkCore;
using Domain.Contracts;
using Infrastructure.Implementing;
using Infrastructure;
using Service.Contracts;
using Service.Implementing;

var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();
optionsBuilder.UseSqlServer("server=HOANG; database=BlogDb;" +
                "Trusted_connection=true; TrustServerCertificate=true");

using (BlogDbContext dbContext = new(optionsBuilder.Options))
{
    IUnitOfWork unitOfWork = new UnitOfWork(dbContext);

    ICategoryService categoryService = new CategoryService(dbContext);
    ICommentRepository commentRepository = new CommentRepository(dbContext);
    IPostService postService = new PostService(unitOfWork);
    ITagRepository tagRepository = new TagRepository(dbContext);

    var posts = postService.GetAllPosts();
    foreach (var post in posts)
    {
        Console.WriteLine($"{post.PostId} | {post.Title} | {post.UrlSlug} | {post.Published}");
    }
}
