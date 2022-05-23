using BPack.Common.Pocket;
using BPack.Strap.EditControls;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList.Columns;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BPack.CommonMes.Helpers
{
    public static class LookUpEditHelper
    {
        private static LookUpEditPocket _lep = LookUpEditPocket.GetInstance();
        public static StrapRepositoryItemButtonEdit_ItemMaster _buttonItem;

        #region 공통 메서드

        public static void SetByQuery(LookUpEdit lookUpEdit, string queryID, object parameters, string valueCaption, string displayCaption, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, queryID, parameters, valueCaption, displayCaption);

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetByQuery(LookUpEdit lookUpEdit, string queryID, object parameters, Dictionary<string, string> columnsFieldNameAndCaption, string valueField, string displayField, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, queryID, parameters, columnsFieldNameAndCaption, valueField, displayField);

            if (isTotalRow) TotalRowInsert(lookUpEdit);


            if (isFirstSelect)
            {
                if (lookUpEdit.Properties.DataSource.GetType()
                    == typeof(System.Data.DataTable))
                {
                    FirstRowSelect(lookUpEdit, valueField);
                }
                else
                {
                    FirstRowSelect(lookUpEdit);
                }


                
            }
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetByQuery(RepositoryItemLookUpEdit repositoryItemLookUpEdit, string queryID, object parameters, Dictionary<string, string> columnsFieldNameAndCaption, string valueField, string displayField, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(repositoryItemLookUpEdit, queryID, parameters, columnsFieldNameAndCaption, valueField, displayField);
        }


        public static void SetCommonCode(LookUpEdit lookUpEdit, string compCode, string parentCode, bool total = true, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetCommonCode(lookUpEdit, compCode, parentCode, total);

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetSysCode(LookUpEdit lookUpEdit, string parentCode, bool total = true, bool isFirstSelect = false, bool isTotalRow = false)
        {
            _lep.SetSysCode(lookUpEdit, parentCode, total);

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
        }

        public static void SetGridColumnByQuery(GridColumn gridColumn, string queryID, object parameters, string valueCaption, string displayCaption, bool isDelButton = false)
        {
            _lep.SetGridColumnByQuery(gridColumn, queryID, parameters, valueCaption, displayCaption);

            if (isDelButton) AddDeleteButton(gridColumn);
        }

        public static void SetGridColumnSysCode(GridColumn gridColumn, string parentCode, bool isDelButton = false)
        {
            _lep.SetGridColumnSysCode(gridColumn, parentCode);

            if (isDelButton) AddDeleteButton(gridColumn);
        }

        public static void SetGridColumnCommonCode(GridColumn gridColumn, string compCode, string parentCode, bool isDelButton = false)
        {
            _lep.SetGridColumnCommonCode(gridColumn, compCode, parentCode);

            if (isDelButton) AddDeleteButton(gridColumn);
        }
        public static void SetTreeGridColumnCommonCode(TreeListColumn treeColumn, string compCode, string parentCode, bool isDelButton = false)
        {
            _lep.SetTreeColumnCommonCode(treeColumn, compCode,parentCode);
            
            if (isDelButton) AddDeleteButton(treeColumn);
        }


        public static void SetGridColumnByQuery(TreeListColumn treeColumn, string queryID, object parameters, string valueCaption, string displayCaption, bool isDelButton = false)
        {
            _lep.SetGridColumnByQuery(treeColumn, queryID, parameters, valueCaption, displayCaption);

            if (isDelButton) AddDeleteButton(treeColumn);
        }

        public static void SetTreeColumnSysCode(TreeListColumn treeColumn, string parentCode)
        {
            _lep.SetTreeColumnSysCode(treeColumn, parentCode);
        }

        public static void TotalRowInsert(LookUpEdit lookUpEdit, int insertIndex = 0, string code = "", string name = "ALL")
        {
            var type = lookUpEdit.Properties.DataSource.GetType();

            if (type == typeof(List<LookUpEditDefaultModel>))
            {
                var targetSource = lookUpEdit.Properties.DataSource as List<LookUpEditDefaultModel>;
                if (targetSource != null)
                {
                    var addModel = new LookUpEditDefaultModel { CODE = code, NAME = name, DEL_FG = "N" };
                    targetSource.Insert(insertIndex, addModel);
                }
            }
            else if (type == typeof(List<LookUpEditCommonCodeModel>))
            {
                var targetSource = lookUpEdit.Properties.DataSource as List<LookUpEditCommonCodeModel>;
                if (targetSource != null)
                {
                    var addModel = new LookUpEditCommonCodeModel { C_CODE = code, C_NAME = name };
                    targetSource.Insert(insertIndex, addModel);
                }
            }
            else if (type == typeof(DataTable))
            {
                try
                {
                    var targetSource = lookUpEdit.Properties.DataSource as DataTable;
                    if (targetSource != null)
                    {
                        DataRow newRow = targetSource.NewRow();
                        newRow["Code"] = "";
                        newRow["Name"] = "All";
                        targetSource.Rows.InsertAt(newRow, 0);
                    }
                }
                catch { }
            }



        }

        public static void FirstRowSelect(LookUpEdit lookUpEdit, string Code)
        {
            var type = lookUpEdit.Properties.DataSource.GetType();
            if (type == typeof(System.Data.DataTable))
            {
                
                var targetSource = lookUpEdit.Properties.DataSource as System.Data.DataTable;
                if (targetSource.Rows.Count > 0)
                {
                    lookUpEdit.EditValue = targetSource.Rows[0][Code];
                    //lookUpEdit.EditValue = lokokUpEdit.Properties.GetDataSourceValue(Code, 0).ToString();
                    SetEditorValue(lookUpEdit, lookUpEdit.EditValue);
                }
            }
        }
        public static void SetEditorValue(BaseEdit editor, object value)
        {
            editor.EditValue = value;
            foreach (Binding i in editor.DataBindings)
            {
                i.WriteValue();
            }
            
        }

        public static void FirstRowSelect(LookUpEdit lookUpEdit)
        {
            var type = lookUpEdit.Properties.DataSource.GetType();

            if (type == typeof(List<LookUpEditDefaultModel>))
            {
                var targetSource = lookUpEdit.Properties.DataSource as List<LookUpEditDefaultModel>;
                lookUpEdit.EditValue = targetSource?.Where(r => r.DEL_FG != "Y")?.FirstOrDefault()?.CODE;

                SetEditorValue(lookUpEdit, lookUpEdit.EditValue);
                //lookUpEdit.Refresh();
            }
            else if (type == typeof(List<LookUpEditCommonCodeModel>))
            {
                var targetSource = lookUpEdit.Properties.DataSource as List<LookUpEditCommonCodeModel>;
                lookUpEdit.EditValue = targetSource?.FirstOrDefault()?.C_CODE;

                SetEditorValue(lookUpEdit, lookUpEdit.EditValue);
                //lookUpEdit.Refresh();
            }
           
        }

        //public static void FirstRowSelect(StrapLookUpEdit lookUpEdit)
        //{
        //    var targetSource = lookUpEdit.Properties.DataSource as List<LookUpEditCommonCodeModel>;
        //    lookUpEdit.EditValue = targetSource?.FirstOrDefault()?.C_CODE;
        //}

        public static void Orderby(LookUpEdit lookUpEdit, string valueMember = "CODE", ColumnSortOrder columnSortOrder = ColumnSortOrder.Ascending)
        {
            LookUpColumnInfo columnInfo = lookUpEdit.Properties.Columns?[valueMember];
            if (null == columnInfo) columnInfo = lookUpEdit.Properties.Columns?.FirstOrDefault();
            columnInfo.SortOrder = columnSortOrder;
        }

        public static void AddDeleteButton(RepositoryItemLookUpEdit rpsLookUpEdit)
        {
            if (rpsLookUpEdit == null) return;

            if (rpsLookUpEdit.Buttons.Where(r => r.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Close).Count() == 0)
            {
                var deleteButton = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close);
                rpsLookUpEdit.Buttons.Add(deleteButton);

                rpsLookUpEdit.ButtonClick += (object sender, ButtonPressedEventArgs e) =>
                {
                    var lookUpEdit = sender as LookUpEdit;
                    if (lookUpEdit == null) return;

                    switch (e.Button.Kind)
                    {
                        case ButtonPredefines.Close:
                            lookUpEdit.EditValue = null;
                            break;
                    };
                };
            }
        }

        public static void AddDeleteButton(GridColumn gridColumn)
        {
            AddDeleteButton(gridColumn.ColumnEdit as RepositoryItemLookUpEdit);
        }

        public static void AddDeleteButton(TreeListColumn treeColumn)
        {
            AddDeleteButton(treeColumn.ColumnEdit as RepositoryItemLookUpEdit);
        }

        /// <summary>
        /// PopUp filter 적용 (목록 필터링)
        /// </summary>
        /// <param name="repositoryItemLookUpEdit"></param>
        /// <param name="criteria"></param>
        public static void PopupFilter(this LookUpEdit lookupEdit, string criteria = "DEL_FG != 'Y'")
        {
            var type = lookupEdit.Properties.DataSource.GetType();
            if (type == typeof(List<LookUpEditDefaultModel>))
            {
                var source = (lookupEdit.Properties.DataSource as List<LookUpEditDefaultModel>);
                if (source == null || source.Where(r => r.DEL_FG == "Y").Count() == 0) return;

                lookupEdit.PopupFilter += (object sender, PopupFilterEventArgs e) =>
                {
                    e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(criteria);
                };
            }
        }

        #endregion ~공통 메서드

        public static void SetCompCode(GridColumn gridColumn, object parameters = null)
        {
            _lep.SetGridColumnByQuery(gridColumn, "CompList", parameters, "회사코드", "회사명");
        }

        public static void SetCompCode(LookUpEdit lookUpEdit, object parameters = null, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "CompList", parameters, "회사코드", "회사명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetPlantCode(LookUpEdit lookUpEdit, object parameters, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "PlantList", parameters, "공장코드", "공장명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetPlantCode(LookUpEdit lookUpEdit, string compCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "PlantList", new { COMP_CD = compCd }, "공장코드", "공장명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetWareHouse(LookUpEdit lookUpEdit, string compCd, string plantCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "WareHouses_WithCode", new { COMP_CD = compCd, PLANT_CD = plantCd }, "창고코드", "창고명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetWareHouse(GridColumn gridColumn, string compCd, string plantCd)
        {
            _lep.SetGridColumnByQuery(gridColumn, "WareHouses_WithCode", new { COMP_CD = compCd, PLANT_CD = plantCd }, "창고코드", "창고명");
        }

        public static void SetWareHouse(CheckedComboBoxEdit cbx, string compCd, string plantCd, bool isCheckAll = true)
        {
            var simplePocket = SimplePocket.GetInstance();
            var source = simplePocket.SelectData("WareHouses_WithCode", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
            });
            cbx.Properties.DataSource = source;
            cbx.Properties.ValueMember = "CODE";
            cbx.Properties.DisplayMember = "NAME";
            cbx.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
            cbx.Properties.PopupFormMinSize = new Size(cbx.Size.Width, 500);

            if (isCheckAll) cbx.CheckAll();
        }

        public static void SetLocation(CheckedComboBoxEdit cbx, string compCd, string plantCd, string warehouseList, bool isCheckAll = true)
        {
            var simplePocket = SimplePocket.GetInstance();
            var source = simplePocket.SelectData("Locations_ByWarehouse", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                WH_CD_LIST = warehouseList
            });
            cbx.Properties.DataSource = source;
            cbx.Properties.ValueMember = "CODE";
            cbx.Properties.DisplayMember = "NAME";
            cbx.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
            cbx.Properties.PopupFormMinSize = new Size(cbx.Size.Width, 500);

            if (isCheckAll) cbx.CheckAll();
        }

        public static void SetLocation(LookUpEdit lookUpEdit, string compCd, string plantCd, string wareHouseCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "Locations_WithCode", new { COMP_CD = compCd, PLANT_CD = plantCd, WH_CD = wareHouseCd }, "위치코드", "위치명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetLocation(GridColumn gridColumn, string compCd, string plantCd, string wareHouseCd)
        {
            _lep.SetGridColumnByQuery(gridColumn, "Locations_WithCode", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                WH_CD = wareHouseCd
            }, "위치코드", "위치명");
        }

        public static void SetRouteNo(LookUpEdit lookUpEdit, string compCd, string plantCd, string wcCd, string itemCd)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                {"ROUTE_NO", "라우팅번호" },
                {"ROUTE_REV","Rev." },
                {"VALID_FROM_DT","시작일" },
                {"VALID_TO_DT","종료일" }
            };
            _lep.SetByQuery(lookUpEdit, "RouteNoList", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                ITEM_CD = itemCd,
                WC_CD = wcCd
            }, keyValuePairs, "ROUTE_NO", "ROUTE_NO");
            lookUpEdit.Properties.Columns["VALID_FROM_DT"].FormatType = DevExpress.Utils.FormatType.DateTime;
            lookUpEdit.Properties.Columns["VALID_FROM_DT"].FormatString = "yyyy-MM-dd";
            lookUpEdit.Properties.Columns["VALID_TO_DT"].FormatType = DevExpress.Utils.FormatType.DateTime;
            lookUpEdit.Properties.Columns["VALID_TO_DT"].FormatString = "yyyy-MM-dd";
            lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }

        public static void SetWorkCenter(LookUpEdit lookUpEdit, string compCd, string plantCd, string workCenterType = "", bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "CommonMes_WorkCenter", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                //2021.10.05 덕양산업 상위 작업장 없음 주석처리
                //PARENT_WC_CD = parentWorkCenterCode,
                WC_TYPE = workCenterType
            }, "작업장코드", "작업자명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetWorkCenterInfo(LookUpEdit lookUpEdit
            , string compCd, string plantCd, string workCenterGroup , Dictionary<string, string> columnsFieldNameAndCaption
             , bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "MD.WKCT.Select", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                //2021.10.05 덕양산업 상위 작업장 없음 주석처리
                //PARENT_WC_CD = parentWorkCenterCode,
                WC_GR = workCenterGroup
            }
            , columnsFieldNameAndCaption
            , "WC_CD", "WC_NM");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }


        public static void SetWorkCenter(GridColumn gridColumn, string compCd, string plantCd, string parentWorkCenterCode = "", string workCenterType = "")
        {
            _lep.SetGridColumnByQuery(gridColumn, "CommonMes_WorkCenter", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                PARENT_WC_CD = parentWorkCenterCode,
                WC_TYPE = workCenterType
            }, "작업장코드", "작업자명");

        }

        public static void SetDeviceID(LookUpEdit lookUpEdit, string compCd, string plantCd, string parentWorkCenterCode = "", bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "DeviceList", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                WC_CD = parentWorkCenterCode
            }, "디바이스코드", "디바이스명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetShiftCode(LookUpEdit lookUpEdit, string compCd, string plantCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "ShiftList_WithCode", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd
            }, "근무조코드", "근무조명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetShiftCode(GridColumn gridColumn, string compCd, string plantCd, bool isTotalRow = false, bool isFirstSelect = false)
        {
            _lep.SetGridColumnByQuery(gridColumn, "ShiftList_WithCode", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd
            }, "근무조코드", "근무조명");

        }

        public static void SetGirType(LookUpEdit lookUpEdit, string compCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "GirType", new
            {
                COMP_CD = compCd
            }, "수불유형코드", "수불유형명");
            if (isFirstSelect == true)
            {
                lookUpEdit.EditValue = ((List<LookUpEditDefaultModel>)lookUpEdit.Properties.DataSource).FirstOrDefault()?.CODE;
            }

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetGirType(GridColumn gridColumn, string compCd)
        {
            _lep.SetGridColumnByQuery(gridColumn, "GirType", new
            {
                COMP_CD = compCd
            }, "수불유형코드", "수불유형명");
        }

        public static void SetDeliveryPlace(LookUpEdit lookUpEdit, string compCd, string plantCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "DeliveryPlaceList", new { DEL_FG = "N", COMP_CD = compCd, PLANT_CD = plantCd }, "납품장소코드", "납품장소명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetBusinessPartner(LookUpEdit lookUpEdit, string compCd, bool isPurchase, bool isSales, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "BusinessPartner_IsPur_Sales", new
            {
                COMP_CD = compCd,
                IS_PURCHASE = isPurchase,
                IS_SALES = isSales
            }, "거래처코드", "거래처명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetGridBusinessPartner(GridColumn gridColumn, string compCd, bool isPurchase, bool isSales)
        {
            _lep.SetGridColumnByQuery(gridColumn, "BusinessPartner_IsPur_Sales", new
            {
                COMP_CD = compCd,
                IS_PURCHASE = isPurchase,
                IS_SALES = isSales
            }, "거래처코드", "거래처명");
        }

        /// <summary>
        /// 납품처가 등록된 거래처 목록
        /// </summary>
        public static void SetBusinessPartner_RegisteredGate(LookUpEdit lookUpEdit, string compCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "BpaList_RegisteredGate", new
            {
                COMP_CD = compCd
            }, "거래처코드", "거래처명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        /// <summary>
        /// 거래처 목록
        /// </summary>
        public static void SetGateList(LookUpEdit lookUpEdit, string compCd, string bpCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "GateList", new
            {
                COMP_CD = compCd,
                BP_CD = bpCd
            }, "납품처코드", "납품처명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetItemType(LookUpEdit lookUpEdit, string compCd, bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true)
        {
            _lep.SetByQuery(lookUpEdit, "ItemType", new { COMP_CD = compCd }, "품목유형코드", "품목유형명");

            if (isTotalRow) TotalRowInsert(lookUpEdit);
            if (isFirstSelect) FirstRowSelect(lookUpEdit);
            if (isDelFilter) PopupFilter(lookUpEdit);
        }

        public static void SetItemType(GridColumn gridColumn, string compCd)
        {
            _lep.SetGridColumnByQuery(gridColumn, "ItemType", new { COMP_CD = compCd }, "위치코드", "위치명");
        }

        #region 비가동 항목 선택

        /// <summary>
        /// 비가동 항목 선택
        /// </summary>
        /// <param name="gridColumn">Grid</param>
        /// <param name="compCd">회사</param>
        /// <param name="plantCd">공장</param>
        /// <param name="WcCd">작업장</param>
        /// <param name="nowkGroupCd">비가동 대분류</param>
        public static void SetNowk(GridColumn gridColumn, string compCd, string plantCd, string WcCd = "", string nowkGroupCd = "")
        {

            _lep.SetGridColumnByQuery(gridColumn, "NowkList", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                WC_CD = WcCd,
                NOWK_GROUP_CD = nowkGroupCd
            } , "비가동코드", "비가동");
        }

        /// <summary>
        /// 비가동 항목 선택
        /// </summary>
        /// <param name="gridColumn">Grid</param>
        /// <param name="compCd">회사</param>
        /// <param name="plantCd">공장</param>
        /// <param name="WcCd">작업장</param>
        /// <param name="nowkGroupCd">비가동 대분류</param>
        public static void SetNowk(LookUpEdit lookUpEdit, string compCd, string plantCd, string WcCd = "", string nowkGroupCd = ""
            , bool isTotalRow = false, bool isFirstSelect = false, bool isDelFilter = true
            )
        {
            _lep.SetByQuery(lookUpEdit, "NowkList", new
            {
                COMP_CD = compCd,
                PLANT_CD = plantCd,
                WC_CD = WcCd,
                NOWK_GROUP_CD = nowkGroupCd
            }, "코드", "비가동");

        }

        #endregion
    }
}
