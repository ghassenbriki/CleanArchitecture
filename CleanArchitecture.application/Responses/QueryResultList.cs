using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.Responses
{
    public class QueryResultList<T> where T : class
    {
        public string? Message { get; set; }
        public IReadOnlyList<T> Items { get; set; } = new List<T>();

        public int count => Items.Count;
        public List<string>? Errors { get; set; }
    }
}
