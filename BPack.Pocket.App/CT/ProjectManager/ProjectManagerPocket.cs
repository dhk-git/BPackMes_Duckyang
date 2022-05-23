using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.CT.ProjectManager;

namespace BPack.Pocket.App.CT.ProjectManager
{
    public class ProjectManagerPocket : PocketBase
    {
        public ProjectManagerPocket()
        {
            InitPocket("ProjectManager");
        }

        public void SavePrjectActivityModel(ProjectActivityModel projectActivityModel)
        {
            PocketExecute("CT.ProjectManager.ProjectActivity.Save", GetParameters_StrapDisableParam(projectActivityModel));
        }

        public void SavePrjectActivityModels(List<ProjectActivityModel> projectActivityModels)
        {
            PocketExecute("CT.ProjectManager.ProjectActivity.Save", GetParameters_StrapDisableParam(projectActivityModels));
        }

        public void SavePrjectDetialModel(ProjectDetailModel projectDetialModel)
        {
            PocketExecute("CT.ProjectManager.ProjectDetail.Save", GetParameters_StrapDisableParam(projectDetialModel));
        }

        public void SavePrjectDetialModels(List<ProjectDetailModel> projectDetialModels)
        {
            PocketExecute("CT.ProjectManager.ProjectDetail.Save", GetParameters_StrapDisableParam(projectDetialModels));
        }

        public void SavePrjectHeaderModel(ProjectHeaderModel projectHeaderModel)
        {
            PocketExecute("CT.ProjectManager.ProjectHeader.Save", GetParameters_StrapDisableParam(projectHeaderModel));
        }

        public void SavePrjectHeaderModels(List<ProjectHeaderModel> projectHeaderModels)
        {
            PocketExecute("CT.ProjectManager.ProjectHeader.Save", GetParameters_StrapDisableParam(projectHeaderModels));
        }

        public void SavePrjectMemberModel(ProjectMemberModel projectMemberModel)
        {
            PocketExecute("CT.ProjectManager.ProjectMember.Save", GetParameters_StrapDisableParam(projectMemberModel));
        }

        public void SavePrjectMemberModels(List<ProjectMemberModel> projectMemberModels)
        {
            PocketExecute("CT.ProjectManager.ProjectMember.Save", GetParameters_StrapDisableParam(projectMemberModels));
        }

        public List<ProjectActivityModel> SelectProjectActivityModels(ProjectManagerModelArgs args)
        {
            return PocketQuery<ProjectActivityModel>("CT.ProjectManager.ProjectActivity.Select", new
            {
                PJD_NO = args.Select_Pjd_No
            });
        }

        public List<ProjectDetailModel> SelectProjectDetailModels(ProjectManagerModelArgs args)
        {
            return PocketQuery<ProjectDetailModel>("CT.ProjectManager.ProjectDetail.Select", new
            {
                PJT_NO = args.Select_Pjt_No,
                PJT_TASK_CLS = args.Select_Main_Pjt_Task_Cls
            });
        }

        public List<ProjectHeaderModel> SelectProjectHeaderModels(ProjectManagerModelArgs args)
        {
            return PocketQuery<ProjectHeaderModel>("CT.ProjectManager.ProjectHeader.Select", new
            {
                PJT_NO = args.Select_Main_Pjt_No,
                PJT_NM = args.Select_Main_Pjt_Nm
            });
        }

        public List<ProjectMemberModel> SelectProjectMemberModels(ProjectManagerModelArgs args)
        {
            return PocketQuery<ProjectMemberModel>("CT.ProjectManager.ProjectMember.Select", new
            {
                PJT_NO = args.Select_Pjt_No
            });
        }
    }
}
