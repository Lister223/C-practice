using System;

namespace ConsoleApp1
{
    class Video
    {
        public string title;
        public string author;
        private string type;
        public static int video_count = 0;

        private List<string> types = new List<string> { "教育", "娛樂" ,"音樂","其他"};

        public Video(string t, string a, string ty)
        {
            title = t;
            author = a;
            Type = ty;
            video_count++;
        }

        public int get_Video_count()  
        {
            return video_count;
        } 


        public string Type
        {
            get { return type; }
            set {
                if(types.Contains(value))
                {
                    type = value;
                }
                else
                {
                    type = "其他";
                }
            }
        }
    }
}
