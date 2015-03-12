namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public interface IComment
    {
        List<string> Comments { get; }
        void AddComment(string comment);
    }
}
