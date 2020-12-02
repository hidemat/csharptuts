using System;

namespace StackOverflow
{
    public class StackPost
    {
        //Members
        ///fields
        private int _voteCount;
        ///properties
        public string Title { get; set;}
        public string Description { get; set; }
        public DateTime PostDate { get; private set; }
        
        ///constructors
        public StackPost(DateTime pd)
        {
            PostDate = pd;
        }
        
        ///logic_properties
        public int VoteCount { get { return _voteCount; } }
        //--members

        //Methods
        public void UpVote()
        {
            _voteCount ++;
        }

        public void DownVote()
        {
            _voteCount --;
        }
        //--methods
    }
}