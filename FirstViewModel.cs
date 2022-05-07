using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kamishibai;

namespace GettingStarted
{
    [Navigate]
    public class FirstViewModel
    {
        public FirstViewModel(string message)
        {
            Message = message;
        }
        public string Message { get; }
    }
}