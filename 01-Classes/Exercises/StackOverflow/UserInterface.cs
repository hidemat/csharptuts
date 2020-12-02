using System;

namespace StackOverflow
{
    public class UserInterface
    {
        private string _getUserInput()
        {
            Console.WriteLine("\nPlease type: 'upvote', 'downvote', or 'exit'");

            return Console.ReadLine();
        }

        public void StartLoop()
        {
            var proceed = true;
            Console.WriteLine("Welcome to StackOverflow Post Simulator.");
            Console.WriteLine("\nPlease create a post.");
            
            StackPost post = new StackPost(DateTime.Now);

            Console.WriteLine("\nWhat's the title of your post?");
            post.Title = Console.ReadLine();

            Console.WriteLine("\nWhat's the description?");
            post.Description = Console.ReadLine();

            while (proceed)
            {
                switch (_getUserInput())
                {
                    case "upvote":
                        post.UpVote();
                        Console.WriteLine("\n## Added 1 vote.");
                        Console.WriteLine("## The vote count for this post is: {0}", post.VoteCount);
                        break;
                    
                    case "downvote":
                        post.DownVote();
                        Console.WriteLine("\n## Subtracted 1 vote.");
                        Console.WriteLine("## The vote count for this post is: {0}", post.VoteCount);
                        break;

                    case "exit":

                        proceed = false;
                        break;

                    default:
                        Console.WriteLine("\n## Invalid command.");
                        break;

                }
            }
        }
    }
}