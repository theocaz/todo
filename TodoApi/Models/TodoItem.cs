using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id{get; set;}

        public string Name{get;set;}

        public bool IsComplete{get;set;}

        public DateTime Deadline{get;set;}

        public string Description{get;set;}
    }
}