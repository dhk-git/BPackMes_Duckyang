using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.QC.NcrRegJudge
{
    public class NcrRegJudgeModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Start_dt { get; set; }
        public DateTime Select_Main_End_dt { get; set; }

        public string Select_Main_Judge_Result { get; set; }

        public string NCD_NO_KEY { get; set; }

        public string JUDGE_RESULT { get; set; }

        /// <summary>
        /// ������ ����(�ܷ�)
        /// </summary>
        public int REMAIN_QTY { get; set; }

        /// <summary>
        /// ������ ����
        /// </summary>
        public int DEFECT_QTY { get; set; }

        //2022.02.10 �߰�
        //������ ��ǰ ��Ͻ� �ű� �ĺ�ǥ ���� ����
        // N �� ��� �ű� �ĺ�ǥ ���� ����,�˾�â���� Ȯ�� ,�ű� �ĺ�ǥ ���� ���� �˾� ȣ��
        // Y �� ��� �ű� �ĺ�ǥ ���� ,�ű� �ĺ�ǥ ����
        public string JUDGE_NEW_PRINT_YN { get; set; }

        //������ ǰ�� �� ���� �ű� �ĺ�ǥ ���� ���� ����
        //Y�� �⺻
        //N�� ��쿡�� ��ǰ�� 1���ۿ� ���ϴ� ���� üũ
        public string JUDGE_HU_STATUS { get; set; }

        public string PRE_HU_NO { get; set; }

    }
}
