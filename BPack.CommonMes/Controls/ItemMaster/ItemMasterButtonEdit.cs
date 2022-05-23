using BPack.Strap.EditControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.ItemMaster
{
    [ToolboxItem(true)]
    public class ItemMasterButtonEdit : StrapButtonEdit
    {
        private ItemMasterSeletor _itemMasterSelector;
        public event EventHandler<ItemMasterSelectedEventArgs> SelectedComplate;
        public ItemMasterButtonEdit()
        {

        }

        public void InitStrap()
        {
            this.ToolTip = "우측(···)버튼 혹은 F1 키를 누르면 품목조회창이 뜹니다.";
            _itemMasterSelector = new ItemMasterSeletor();
            _itemMasterSelector.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ButtonClick += StrapButtonEdit_ItemInfo_ButtonClick;
            this.KeyDown += StrapButtonEdit_ItemInfo_KeyDown;
            _itemMasterSelector.SelectedComplate += ItemMasterSelector_SelectedComplate; ;
            this.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }

        private void ItemMasterSelector_SelectedComplate(object sender, ItemMasterSelectedEventArgs e)
        {
            //벨류체인치 헨들러 제거
            this.Validated -= StrapButtonEdit_ItemInfo_Validated;
            this.EditValue = e.SelectedItemCode;
            this.ItemMasterModel = e.SeletedItemMasterModel;
            //벨류체인치 헨들러 추가
            this.Validated += StrapButtonEdit_ItemInfo_Validated;
            SelectedComplate?.Invoke(this, e);
        }

        private void StrapButtonEdit_ItemInfo_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "등록되지 않은 품번 입니다.";
        }

        private void StrapButtonEdit_ItemInfo_Validating(object sender, CancelEventArgs e)
        {
            this.ItemMasterModel = _itemMasterSelector.GetItemMasterModel(this.EditValue?.ToString());
            if (this.ItemMasterModel == null)
            {
                e.Cancel = true;
            }
        }

        private void StrapButtonEdit_ItemInfo_Validated(object sender, EventArgs e)
        {

        }

        private void StrapButtonEdit_ItemInfo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                _itemMasterSelector.ShowDialog();
            }
        }

        private void StrapButtonEdit_ItemInfo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _itemMasterSelector.ShowDialog();
        }
        public void InitCompCode(string compCode)
        {
            _itemMasterSelector.SetCompCode(compCode);
        }
        public void InitPlantCode(string plantCode)
        {
            _itemMasterSelector.SetPlantCode(plantCode);
        }

        public void DataClear()
        {
            _itemMasterSelector.DataClear();
        }

        public ItemMasterModel ItemMasterModel { get; set; }
    }
}
