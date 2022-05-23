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
    public class FileManagerFileGroupModel : ModelBase_CommonColumns
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
    }
}
