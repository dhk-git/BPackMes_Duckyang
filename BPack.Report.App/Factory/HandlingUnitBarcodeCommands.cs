using BPack.Report.App.Common;
using BPack.Report.App.HandlingUnit.Models;
using BPack.Report.App.HandlingUnit.Pocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPack.Report.App.HandlingUnit.Commands
{
    public static class HandlingUnitBarcodeCommands
    {
        private static readonly HandlingUnitModelArgs _args = new HandlingUnitModelArgs();
        private static readonly HandlingUnitPocket _pocket = new HandlingUnitPocket();

        public static string density = "-5";
        private static string strDensity = int.Parse(density) < 0 ? string.Format("{0:00}", (object)int.Parse(density)) : string.Format("{0:+00}", (object)int.Parse(density));
        
        #region 메서드

        public static string GetHangul2(string st)
        {
            byte[] bytes = Encoding.GetEncoding(949).GetBytes(st);
            byte[] array = new byte[2];
            int index1 = 0;
            int index2 = index1;
            while (index1 <= bytes.Length - 1)
            {
                Array.Resize<byte>(ref array, index2 + 2);
                if (bytes[index1] > (byte)128)
                {
                    array[index2] = bytes[index1];
                    ++index1;
                    array[index2 + 1] = bytes[index1];
                }
                else
                {
                    array[index2] = (byte)201;
                    array[index2 + 1] = (byte)((uint)bytes[index1] + 129U);
                }
                ++index1;
                index2 += 2;
            }
            return Encoding.Default.GetString(array, 0, array.Length);
        }

        public static string ControlCodeTransfer(BarcodeFontType barcodeFontType, string data)
        {
            string transData = data;
            if (transData == null) return transData;

            switch (barcodeFontType)
            {
                /*
                file:///C:/Users/MJLee/Desktop/%7B20120330014511%7DB-EX_Ifm_3rdA.pdf
                page 386 / 406

                c How to send control code data:
                    NUL(00H)→ >@(3EH, 40H)
                    SOH(01H)→ >A(3EH, 41H)
                    STX(02H)→ >B(3EH, 42H)
                    to
                    GS(1DH) → >](3EH, 5DH)
                    RS(1EH) → >^(3EH, 5EH)
                    US(1FH) → >_(3EH, 5FH)

                d How to send a special code:
                    >(3EH)  → >0(3EH, 30H)
                    FNC1      >1(3EH, 31H)

                e How to send a Kanji code:
                    Shift JIS
                    JIS hexadecimal
                 (For details, refer to the section for the Bar Code Data Command.)
                */
                case BarcodeFontType.DataMatrix:

                    // Special Code Transper
                    var SP1 = Convert.ToString((char)62);
                    var SP1_Conv = String.Concat(SP1, (char)(48));  // > : >0
                    if (transData.Contains(SP1))
                        transData = transData.Replace(SP1, SP1_Conv);

                    // Control Code Transper
                    for (int i = 0; i < 32; i++)
                    {
                        string source = Convert.ToString((char)i);

                        //if (transData.Contains(source) && new int[] { 29, 30 }.Contains(i))
                        if (transData.Contains(source))
                        {
                            var target = String.Concat((char)62, (char)(i + 64));
                            transData = transData.Replace(source, target);
                        }
                    }
                    break;
                default:
                    transData = data;
                    break;
            }

            return transData;

        }


        //2021.03.15 반제품 개별식별표 바코드(시리얼) 라벨 생성
        /// <summary>
        /// 반제품 개별식별표 바코드(시리얼) 라벨 출력
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public static List<String> CreateSerialSemiBarcodes(List<string> huNoList)
        {
            if (huNoList.Count == 0) return null;
            _args.Select_HuNoList = huNoList;
            var models = _pocket.SelectSerialSemiBarcodeReportModels(_args);

            var sendList = new List<String>();
            foreach (var model in models)
            {
                var cmd = CreateSemiBarcodeCommand(model);
                sendList.Add(cmd);
            }

            return sendList;

        }

     

        /// <summary>
        /// 완제품 개별식별표 바코드 라벨 생성
        /// </summary>
        /// <param name="huNoList"></param>
        /// <returns></returns>
        public static List<String> CreateSerialGoodsBarcodes(List<string> huNoList)
        {
            if (huNoList.Count == 0) return null;
            _args.Select_HuNoList = huNoList;

            var models = _pocket.SelectSerialGoodsBarcodeReportModels(_args) as List<SerialGoodsBarcodeReportModel>;
            
            var sendList = new List<String>();
            foreach (var model in models)
            {
                var cmd = CreateGoodsBarcodeCommand(model);
                sendList.Add(cmd);
            }

            return sendList;
        }

        #endregion ~메서드

        /// <summary>
        /// 반제품 식별표(시리얼) 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private static String CreateSemiBarcodeCommand(SerialSemiBarcodeReportModel model)
        {
            string customerBarcode = ControlCodeTransfer(BarcodeFontType.DataMatrix, model.BARCODE_FULL_NO);
            StringBuilder stringBuilder = new StringBuilder();
            //버퍼 클리어
            stringBuilder.AppendLine("{C|}");
            //사이즈 지정 35 * 55
            stringBuilder.AppendLine("{D0580,0350,0550|}");

            //[1]품번
            stringBuilder.Append("{PV01;0210,0050,0030,0070,B,11,B=" + model.ITEM_CD?.Trim() + "|}");
            //[2]메트릭스 바코드 
            stringBuilder.AppendLine("{XB02;0190,0050,Q,20,05,06,1=" + customerBarcode + "|}");

            //[3] HU_BARCODE
            stringBuilder.Append("{PV03;0025,0050,0030,0050,B,11,B=" + model.HU_BARCODE.Split('/')[0]?.Trim() + "|}");

            //[4] LOT NO
            stringBuilder.Append("{PV04;0130,0180,0030,0040,B,11,B=" + model.LOT_NO?.Trim() + "|}");
            //[5] 출력
            stringBuilder.AppendLine("{XS;I,0001,0012D3201|}");
            return stringBuilder.ToString();
        }

        private static String CreateGoodsBarcodeCommand(SerialGoodsBarcodeReportModel model)
        {
            string customerBarcode = ControlCodeTransfer(BarcodeFontType.DataMatrix, model.CUSTOMER_BARCODE);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{D0730,0700,0700|}");
            stringBuilder.AppendLine("{AX;+000,+000,+00|}");
            stringBuilder.AppendLine("{AY;" + strDensity + ",0|}");
            stringBuilder.AppendLine("{C|}");
            stringBuilder.AppendLine("{XB01;0675,0050,Q,20,03,06,1=" + customerBarcode + "|}");
            stringBuilder.AppendLine("{XB02;0550,0050,Q,20,05,06,1=" + customerBarcode + "|}");

            //switch (model.SYMBOL)
            //{
            //    case "HMC":
            //        stringBuilder.AppendLine("{XQ;01,0,L|}"); // HMC LOGO 2번 -> 1번
            //        break;
            //    case "KMC":
            //        stringBuilder.AppendLine("{XQ;02,0,L|}"); // KMC LOGO 3번 -> 2번 회전90 X 605 Y 520
            //        break;
            //}
            
            //SYMBOL 데이터가 null로 들어와서 조건 제거함 - 20201224 곽동혁 TODO : SYMBOL 데이터 확인할 것
            stringBuilder.AppendLine("{XQ;02,0,L|}"); // KMC LOGO 3번 -> 2번 회전90 X 605 Y 520

            //stringBuilder.AppendLine("{XQ;01,0,L|}"); // CCC LOGO
            //stringBuilder.AppendLine("{ PV15; 0430,0575,0020,0023,B,11,B = " + frmProcPunch.BarPrnInfo[intPrnPLC].strCCCNo + " |}"); // CCC No ??

            stringBuilder.Append("{XB03;0320,0040,9,1,03,1,0090,-0000000001,000,0,00=" + model.HU_BARCODE + "|}");
            stringBuilder.Append("{XB04;0320,0540,T,M,05,A,1,M2,K7=" + model.HU_BARCODE + "|}");
            stringBuilder.Append("{PV01;0605,0260,0050,0100,B,11,B=" + model.ALC_CD?.Trim() + "|}");
            stringBuilder.Append("{PV02;0440,0260,0055,0150,B,11,B=" + model.ALC_CD?.Trim() + "|}");

            stringBuilder.Append("{PV03;0385,0350,0040,0040,B,11,B=" + model.WORK_DT + "|}");
            stringBuilder.Append("{PV04;0340,0040,0040,0040,B,11,B=" + model.PARTNO + "|}");
            stringBuilder.Append("{PC01;0420,0040,2,2,51,+00,11,B=" + model.WORKER + "|}"); // GetHangul2(model.WORKER);

            stringBuilder.Append("{PC05;0200,0030,2,1,A,+00,11,B=*" + model.HU_BARCODE + "*|}");
            stringBuilder.Append("{PV06;0145,0030,0040,0040,B,11,B=" + model.TEXTURE1 + "|}");
            stringBuilder.Append("{PV07;0095,0030,0040,0040,B,11,B=" + model.TEXTURE2 + "|}");
            stringBuilder.Append("{PV08;0045,0030,0040,0040,B,11,B=" + model.TEXTURE3 + "|}");
            stringBuilder.AppendLine("{XS;I,0001,0012D3201|}");

            //[ESC]XS;I,aaaa,bbbcdefgh(,Skk)[LF][NUL] 
            //c: Type of sensor
            //    0: No sensor
            //    1: Reflective sensor
            //    2: Transmissive sensor(when using normal labels)
            //    3: Transmissive sensor(when using preprinted labels)
            //    4: Reflective sensor(when using a manual threshold value) 

            //d: Issue mode
            //    C: Batch mode
            //    D: Strip mode(with back feed and the strip sensor enabled.)
            //    E: Strip mode(with back feed enabled, the strip sensor ignored, the applicator supported)

            return stringBuilder.ToString();
        }

    }
}
