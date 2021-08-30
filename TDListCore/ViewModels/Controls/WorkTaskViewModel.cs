using System;
using System.Collections.Generic;
using System.Text;

namespace TDListCore
{
    public class WorkTaskViewModel : BaseViewModel
    {
        public bool IsSelected { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
