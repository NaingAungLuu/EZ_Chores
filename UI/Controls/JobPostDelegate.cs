using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZChores.UI.Controls
{
    public interface JobPostDelegate
    {
        void onTapDetails(string postId);
    }
}
