using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.FileManager
{
    public class FileManagerFileModel : ModelBase_CommonColumns
    {

        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string FILE_GROUP_ID_KEY { get; set; }
        [Display(Name = "파일그룹 일련번호")]
        public string FILE_GROUP_ID { get; set; }
        [Display(Name = "파일그룹명")]
        public string FILE_GROUP_NM { get; set; }
        [Display(Name = "메뉴아이디")]
        public string MENU_ID { get; set; }
        [Display(Name = "테이블아이디")]
        public string TABLE_ID { get; set; }
        [Display(Name = "참조용아이디")]
        public string REF_ID { get; set; }


        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int FILE_SEQ_KEY { get; set; }
        [Display(Name = "파일순번")]
        public int FILE_SEQ { get; set; }
        [Display(Name = "파일명")]
        public string FILE_NAME { get; set; }
        [Display(Name = "저장된파일명")]
        public string FILE_NAME_IN_SERVER { get; set; }


        [Display(Name = "생성일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? CREATE_DTTM { get; set; }
        [Display(Name = "생성자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string CREATE_USER_ID { get; set; }

        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }
    }
}
