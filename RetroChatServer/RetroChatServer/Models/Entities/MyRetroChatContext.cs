using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using RetroChatServer.Utils;

namespace RetroChatServer.Models.Entities
{
    public partial class RetroChatContext
    {

        public RetroChatContext(DbContextOptions<RetroChatContext> options) : base(options)
        {
        }

        public void Register(RegisterVM model)
        {
            User user = new User
            {
                UserName = model.UserName,
                Password = model.Password
            };
            User.Add(user);
            SaveChanges();

        }

        ////public async Task<AccountVM> Login(LoginVM model)
        ////{
        ////    User user = await User.SingleOrDefaultAsync(u => u.UserName == model.UserName && u.Password == model.Password);
        ////    return new AccountVM
        ////    {
        ////        Id = user.Id,
        ////        UserName = user.UserName
        ////    };
        ////}

        //public async Task<HomeVM> Home(int id)
        //{
        //    var user = await User
        //        .Where(u => u.Id == id)
        //        .Include(p => p.Post)
        //        .FirstOrDefaultAsync();
        //    List<UserPost> userPosts = new List<UserPost>();

        //    // get filepath to images, and convert to base64string
        //    foreach (var post in user.Post)
        //    {
        //        userPosts.Add(new UserPost
        //        {
        //            Id = post.Id,
        //            Image = "data:image/png;base64," + Convert.ToBase64String(File.ReadAllBytes(post.Image))
        //        });
        //    }
        //    return new HomeVM
        //    {
        //        Id = user.Id,
        //        UserName = user.UserName,
        //        Image = user.Image,
        //        Info = user.Info,
        //        Posts = userPosts.ToArray()

        //    };

        //}


        //public SearchVM[] GetAllUsers()
        //{

        //    return User.Select(u => new SearchVM
        //    {
        //        Id = u.Id,
        //        UserName = u.UserName,
        //        Image = u.Image

        //    }).ToArray();
        //}

        //public HomeVM GetUser(int id)
        //{
        //    return User.Where(u => u.Id == id)
        //        .Select(u => new HomeVM
        //        {
        //            UserName = u.UserName,
        //            Image = u.Image,
        //            Info = u.Info

        //        }).First();
        //}


        //public PostVM GetUserPost(int userId, int postId)
        //{
        //    var user = User
        //        .Where(u => u.Id == userId)
        //        .Include(p => p.Post)
        //        .FirstOrDefault();

        //    return user.Post.Where(p => p.Id == postId)
        //        .Select(p => new PostVM
        //        {
        //            Id = p.Id,
        //            Image = CoolUtil.GetBase64ImageFromDisk(p.Image),
        //            Text = p.Text

        //        }).FirstOrDefault();
        //}


        //public void AddPost(AddPostVM model)
        //{
        //    string folderName = Environment.CurrentDirectory;

        //    // To create a string that specifies the path to a subfolder under your 
        //    // top-level folder, add a name for the subfolder to folderName.
        //    string pathString = Path.Combine(folderName, "Data");
        //    // You can extend the depth of your path if you want to.
        //    //pathString = System.IO.Path.Combine(pathString, "SubSubFolder");
        //    pathString = Path.Combine(pathString, Convert.ToString(model.Id));
        //    // Create the subfolder. 
        //    Directory.CreateDirectory(pathString);

        //    // Create a file name for the file you want to create. 
        //    string fileName = Path.GetRandomFileName();
        //    // Use Combine again to add the file name to the path.
        //    pathString = Path.Combine(pathString, fileName);

        //    string[] split = model.Image.Split(new char[] { ',' }, 2);

        //    byte[] bytesImage = Convert.FromBase64String(split[1]);
        //    File.WriteAllBytes(pathString, bytesImage);

        //    var user = User
        //        .Where(u => u.Id == model.Id)
        //        .Include(p => p.Post)
        //        .FirstOrDefault();

        //    user.Post.Add(new Post
        //    {
        //        Image = pathString,
        //        Text = model.Text,
        //        UserId = model.Id
        //    });
        //    SaveChanges();
        //}
    }
}
