using System;

namespace NiuZiYuanTestProject
{
    public class GetModel
    {
        internal Add AddModel()
        {
            return new Add
            {
                Id = Guid.NewGuid(),
                String = Guid.NewGuid().ToString(),
                DateTime = DateTime.Now
            };
        }

    }

    public class Add
    {
        public Guid Id { get; set; }
        public String String { get; set; }
        public DateTime DateTime { get; set; }
    }
}