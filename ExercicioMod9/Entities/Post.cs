using System;
using System.Text;
using System.Collections.Generic;


namespace ExercicioMod9.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = new List<Comments>();


        public Post() 
        {
        
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comments Comment) 
        {
            Comments.Add(Comment);
        
        }

        public void RemoveComment(Comments Comment)
        {

            Comments.Remove(Comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach (Comments C in Comments)
            {
                sb.AppendLine(C.Text);
            }
            return sb.ToString();


        }
    }
}
