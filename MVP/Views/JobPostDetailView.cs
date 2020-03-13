using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EZChores.Data.DataVO;

namespace EZChores.MVP.Views
{
    interface JobPostDetailView
    {
        void showJobPostDetails(JobPost data);
        void setUserTypeBasedView(Boolean isEmployer);
        void navigateToChoresPanel();

        void openAppliedUsersDialog();
        void showAppliedView(Boolean isApplied);

        void refresh();
    }
}
