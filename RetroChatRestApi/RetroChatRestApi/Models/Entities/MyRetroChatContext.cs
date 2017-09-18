using Microsoft.EntityFrameworkCore;
using RetroChatRestApi.Models.Account;
using RetroChatRestApi.Models.Members;
using RetroChatRestApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroChatRestApi.Models.Entities
{
    public partial class RetroChatContext
    {
        public RetroChatContext(DbContextOptions<RetroChatContext> options) : base(options)
        {
        }

        internal LoginResponse Login(Login model)
        {
            var user = User.SingleOrDefault(u => u.UserName == model.UserName && u.Password == model.Password);
            if (user != null)
            {
                return new LoginResponse
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    LoggedIn = true
                };
            }
            else
            {
                return new LoginResponse
                {
                    LoggedIn = false,
                    Text = "Wrong username or password.."
                };
            }
        }


        internal RegisterResponse Register(Register model)
        {
            if (User.SingleOrDefault(u => u.UserName == model.UserName) == null)
            {
                // create user
                User user = new User
                {
                    UserName = model.UserName,
                    Password = model.Password

                };
                User.Add(user);
                SaveChanges();
                return new RegisterResponse
                {
                    Id = user.Id,
                    Success = true,
                    UserName = model.UserName
                };
            }
            else
            {
                return new RegisterResponse
                {
                    Success = false,
                    Text = "User already exist.."
                };
            }
        }

        internal Home Home(int id)
        {
            var user = User
                .Where(u => u.Id == id)
                .Include(p => p.Post)
                .FirstOrDefault();
            List<UserPost> userPosts = new List<UserPost>();

            // get filepath to images, and convert to base64string
            foreach (var post in user.Post)
            {
                userPosts.Add(new UserPost
                {
                    Id = post.Id,
                    Image = CoolUtil.GetBase64ImageFromDisk(post.Image)
                });
            }
            return new Home
            {
                Id = user.Id,
                UserName = user.UserName,
                Image = user.Image,
                Info = user.Text,
                Posts = userPosts.ToArray()

            };

        }
        internal PostVM GetUserPost(int id, int userId, int postId)
        {
            var user = User
                .Where(u => u.Id == userId)
                .Include(p => p.Post)
                .ThenInclude(p => p.Like)
                .FirstOrDefault();

            var post = user.Post
                .Where(p => p.Id == postId)
                .SingleOrDefault();

            var like = post.Like
                .Where(l => l.UserId == id)
                .SingleOrDefault();

            return user.Post.Where(p => p.Id == postId)
                .Select(p => new PostVM
                {
                    Id = p.Id,
                    UserLike = like.LikeValue == 1 ? true : false,
                    Image = CoolUtil.GetBase64ImageFromDisk(p.Image),
                    Text = p.Text

                }).FirstOrDefault();
        }



        internal Search[] GetAllUsers()
        {
            return User.Select(u => new Search
            {
                Id = u.Id,
                UserName = u.UserName,
                Image = u.Image

            }).ToArray();
        }

        internal void AddPost(AddPost model)
        {
            string pathString = CoolUtil.WritePostToDisk(model);
            var user = User
                .Where(u => u.Id == model.Id)
                .Include(p => p.Post)
                .FirstOrDefault();

            user.Post.Add(new Post
            {
                Image = pathString,
                Text = model.Text,
                UserId = model.Id
            });
            SaveChanges();
        }

        internal bool LikePost(PostLike model)
        {
            var user = User
                .Where(u => u.Id == model.UserId)
                .Include(p => p.Post)
                .ThenInclude(p => p.Like)
                .FirstOrDefault();

            var post = user.Post
                .Where(p => p.Id == model.PostId)
                .SingleOrDefault();

            var like = post.Like
                .Where(l => l.UserId == model.Id)
                .SingleOrDefault();

            if (like != null)
            {
                if (like.LikeValue == 0)
                {
                    like.LikeValue = 1;
                }
                else
                {
                    like.LikeValue = 0;
                }
                SaveChanges();
                return like.LikeValue == 1 ? true : false;
            }
            else
            {
                post.Like.Add(new Like
                {
                    UserId = model.Id,
                    LikeValue = 1,
                    PostId = model.PostId
                });
                SaveChanges();
                return true;
            }

        }

        internal void CommentPost(PostComment model)
        {
            var user = User
                .Where(u => u.Id == model.UserId)
                .Include(p => p.Post)
                .ThenInclude(p => p.Comment)
                .FirstOrDefault();

            var post = user.Post
                .Where(p => p.Id == model.PostId)
                .SingleOrDefault();

            post.Comment.Add(new Comment
            {
                UserId = model.Id,
                TextValue = model.Text,
                PostId = model.PostId
            });
            

        }


    }
}
