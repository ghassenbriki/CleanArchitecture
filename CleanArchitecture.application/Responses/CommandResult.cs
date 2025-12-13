using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.Responses
{
    public class CommandResult
    {
        public string? Message { get; set; }

        public List<string>? Errors { get; set; }

    }
}
