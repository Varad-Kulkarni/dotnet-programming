using System.Globalization;

namespace csharp_programming {
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class CommentAttribute : Attribute {
        public String Text { get; set; }
    }
}