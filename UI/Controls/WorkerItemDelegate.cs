using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.UI.Controls
{
    public interface WorkerItemDelegate
    {
        void onTapEmploy(User user);
    }
}
