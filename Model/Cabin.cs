﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanPlast.Dane;
using System.Data;
using System.IO;
using SwConst;
using SldWorks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace SanPlast.Model
{
    class Cabin
    {
        public int Wys { get; set; }
        public int[] Szer { get; set; }
        public List<Szyba> LS { get; set; }
        public bool Strona { get; set; }
        public string Kolor { get; set; }
        public bool Slant { get; set; }
        public int[] SlantDim { get; set; }
        public bool Cutout { get; set; }
        public int[] CutoutDim { get; set; }
        public Image Img()
        {
            Bitmap i = new Bitmap(Image.FromFile(@"F:\SanPlast\Złożenie\ZL.jpg"));
            //Bitmap image2 = (Bitmap)i.Clone();

            WrightText(i, 25, Szer[0].ToString(), new Point(i.Width / 5, i.Height - 50));
            WrightText(i, -25, Szer[1].ToString(), new Point(i.Width - i.Width / 5, i.Height - 50));
            WrightText(i, 0, LS[0].OdSz.ToString(), new Point(i.Width / 5, i.Height / 5 - 20));
            WrightText(i, 0, LS[1].OdSz.ToString(), new Point(i.Width - i.Width / 5, i.Height / 5 - 20));
            WrightText(i, -90, Wys.ToString(), new Point(i.Width - i.Width / 6, i.Height / 2 + 50));
            if (LS[0].OdSz != 0) NewLine(i, LS[0].OdSz > 0 ? 120 : -60, new Point(i.Width / 10, i.Height / 5 - 5));
            if (LS[1].OdSz != 0) NewLine(i, LS[1].OdSz < 0 ? 60 : -120, new Point(i.Width - i.Width / 10, i.Height / 5 - 5));

            if (!Strona) i.RotateFlip(RotateFlipType.RotateNoneFlipX);

            ////Merge two images in bitmap image,
            //Bitmap bitmap = new Bitmap(i.Width + image2.Width, Math.Max(i.Height, image2.Height));
            //using (Graphics g = Graphics.FromImage(bitmap))
            //{
            //    g.DrawImage(image1, 0, 0);
            //    g.DrawImage(image2, image1.Width, 0);
            //}
            ////Show them in a picturebox
            //pictureBox2.Image = bitmap;
            //Graphics G = i.to;
            return i;
        }

        private void NewLine(Bitmap i, int angle, Point P)
        {
            using (Graphics g = Graphics.FromImage(i))
            {
                g.TranslateTransform(P.X, P.Y);
                g.RotateTransform(angle);
                Pen blackPen = new Pen(Color.Black, 5);
                g.DrawLine(blackPen, 0, 0, 0, 50);
                g.DrawLine(blackPen, 0, 50, 10, 30);
                g.DrawLine(blackPen, 0, 50, -10, 30);
            }
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //you can do anything here
        }

        private void WrightText(Bitmap i, int angle, string text, Point P)
        {
            using (Graphics g = Graphics.FromImage(i))
            {
                g.TranslateTransform(P.X, P.Y);
                g.RotateTransform(angle);
                if (!Strona) g.MultiplyTransform(new Matrix(-1, 0, 0, 1, 0, 0));
                Font font = new Font("Arial", 40);
                SizeF textSize = g.MeasureString(text, font);
                g.DrawString(text, font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
            }
        }

        public List<Komponent> LK { get; private set; }
        public string Folder { get; set; }

        public static DataTable Zestawienie { get; private set; }

        public void Policz()
        {
            LK = new List<Komponent>();
            DataTable T = Dane.Dane.DS.Tables["Set"].Clone();
            Zestawienie = new DataTable();
            Zestawienie.Columns.Add(new DataColumn("Ind", typeof(string)));
            Zestawienie.Columns.Add(new DataColumn("Nazwa", typeof(string)));
            Zestawienie.Columns.Add(new DataColumn("J", typeof(string)));
            Zestawienie.Columns.Add(new DataColumn("Il.", typeof(string)));
            Zestawienie.Columns.Add(new DataColumn("Uwaga", typeof(string)));
            foreach (DataRow r in Dane.Dane.DS.Tables["Kabina"].Rows)
            {

                if (r["Element"].ToString().Contains("Szyba"))
                { GetSzyba(r); }
                else
                { GetKomponent(r); }
            }
            SortLK();
            LK.ForEach(x => x.GetDataRow());
            ToCSV(Zestawienie, @"F:\Zamówienie\" + Folder + @"\komponents.csv");

            List<string> GetList(object S) => S.ToString().Split(';').ToList();

            void GetKomponent(DataRow r)
            {
                int val = GetFromString(ChangeLetterToNumber(r["L"]));
                Dane.Dane.DS.Tables["Set"].AsEnumerable()
               .Where(x => x["Element"].ToString() == r["Element"].ToString() && Convert.ToInt32(x["Min"]) <= val && Convert.ToInt32(x["Max"]) >= val).ToList()
               .ForEach(x =>
               {
                   if (x["Docinane"].ToString().Length > 1) GetList(x["Docinane"]).ForEach(y => LK.Add(new Komponent
                   {
                       Indeks = y.ToString(),
                       Ilosc = GetFromString(r["Ilosc"]),
                       Dlugosc = GetFromString(r["L"]) != GetFromString(x["Dl"]) ? GetFromString(r["L"]) : 0,
                       Typ = "Docinany"
                   }));
                   if (x["Ilosciowe"].ToString().Length > 1) GetList(x["Ilosciowe"]).ForEach(y => LK.Add(new Komponent
                   {
                       Indeks = y.ToString(),
                       Ilosc = GetFromString(new object[] { r["Ilosc"], x["Il"] }, '*'),
                       Dlugosc = 0,
                       Typ = "Ilosciowy"
                   }));
                   if (x["m"].ToString().Length > 1) GetList(x["m"]).ForEach(y => LK.Add(new Komponent
                   {
                       Indeks = y.ToString(),
                       Ilosc = GetFromString(r["Ilosc"]),
                       Dlugosc = GetFromString(new object[] { r["L"], 100 }, '+'),
                       Typ = "m"
                   }));
               });
            }

            void GetSzyba(DataRow r)
            {
                int i = Convert.ToInt32(r["NN"]);
                LS[i].Wys = GetFromString(r["L"]);
                LS[i].Sz = GetFromString(r["W"]);
                LS[i].Sz = GetFromString(r["W"]);
                LS[i].Strona = (Strona ? r["Uwaga"].ToString()[0] : r["Uwaga"].ToString()[1]).ToString();
                int[] p = Array.ConvertAll(r["Reg"].ToString().Split(';'), s => int.Parse(s));
                LS[i].OdSzNom = new int[] { p[0], -p[1], p[0] - p[1] };
                LS[i].Adres = @"F:\SanPlast\Szyby\" + r["Element"].ToString() + LS[i].Strona + ".SLDDRW";
                LS[i].Nazwa = r["Element"].ToString();
                LS[i].GetOdchylka();
                Drukuj(LS[i]);
            }

            void Drukuj(Szyba Szyba)
            {
                int errors = 0;
                int warnings = 0;
                SldWorks.SldWorks swApp = new SldWorks.SldWorks();
                string Typ = Szyba.Nazwa.Replace("Szyba ", "") + " " + Szyba.Strona;

                // Открытие файла чертежа
                string drawingFilePath = Szyba.Adres;
                swApp.Visible = true;
                string sConfig = string.Empty;
                ModelDoc2 drawing = swApp.OpenDoc(drawingFilePath, (int)swDocumentTypes_e.swDocDRAWING);
                if (swApp.ActiveDoc != null)
                {
                    ModelDoc2 model = swApp.GetFirstDocument();
                    string[] obj = (string[])((DrawingDoc)drawing).GetSheetNames();

                    CustomPropertyManager cusPropMgr = model.Extension.get_CustomPropertyManager("");
                    string valout = "";
                    cusPropMgr.Add3("Kolor", 30, Kolor, 1);

                    Dimension dim = (Dimension)model.Parameter("D1@PK");
                    dim.SystemValue = Szyba.Wys * .001;
                    dim = (Dimension)model.Parameter("D2@PK");
                    dim.SystemValue = Szyba.Sz * .001;
                    dim = (Dimension)model.Parameter("D3@PK");
                    dim.SystemValue = Szyba.SzG * .001;

                    Note myNote = drawing.InsertNote("$PRPSHEET:\"Kolor\"");
                    Annotation swAnn;
                    long nRetVal;
                    swAnn = (Annotation)myNote.GetAnnotation();
                    myNote.Angle = 0.0;
                    bool bRet = myNote.SetBalloon((int)swBalloonStyle_e.swBS_None, (int)swBalloonFit_e.swBF_Tightest);
                    nRetVal = swAnn.SetLeader2(false, (int)swLeaderSide_e.swLS_SMART, true, false, false, false);
                    bRet = swAnn.SetPosition(0.116336452176916, 2.61970555599255E-02, 0.0);
                    model.ForceRebuild3(false);

                    // Создание новой папки для сохранения модели и чертежа
                    string newFolderPath = @"F:\Zamówienie\" + Folder + "\\";
                    Directory.CreateDirectory(newFolderPath);

                    // Сохранение модели в новой папке
                    string newModelFilePath = newFolderPath + Typ + ".sldprt";
                    model.SaveAs(newModelFilePath);

                    drawing.ForceRebuild3(false);
                    // Сохранение чертежа в новой папке
                    string newDrawingFilePath = newFolderPath + Typ + ".slddrw";
                    drawing.SaveAs2(newDrawingFilePath, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, false, false);

                    // Создание pdf чертежа
                    string pdfFilePath = newFolderPath + Typ + ".pdf";
                    ExportPdfData swExportPDFData = (ExportPdfData)swApp.GetExportFileData((int)swExportDataFileType_e.swExportPdfData);
                    ModelDocExtension swModExt = drawing.Extension;

                    bool boolstatus = ((DrawingDoc)drawing).ActivateSheet(obj[0]);
                    Sheet swSheet = (Sheet)((DrawingDoc)drawing).GetCurrentSheet();
                    DispatchWrapper[] arrObjIn = new DispatchWrapper[1];
                    arrObjIn[0] = new DispatchWrapper(swSheet);
                    boolstatus = swExportPDFData.SetSheets((int)swExportDataSheetsToExport_e.swExportData_ExportSpecifiedSheets, arrObjIn);
                    boolstatus = swModExt.SaveAs(pdfFilePath, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, swExportPDFData, ref errors, ref warnings);
                    swExportPDFData.ViewPdfAfterSaving = true;

                    boolstatus = ((DrawingDoc)drawing).ActivateSheet((obj[1]));
                    swSheet = (Sheet)((DrawingDoc)drawing).GetCurrentSheet();
                    swApp.SetUserPreferenceDoubleValue((int)swUserPreferenceDoubleValue_e.swDxfOutputScaleFactor, 1);

                    string dxfFilePath = newFolderPath + Typ + ".dxf";
                    boolstatus = drawing.SaveAs4(dxfFilePath, (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_Silent, ref errors, ref warnings);

                    swApp.CloseDoc(newDrawingFilePath);
                }

               DataRow R = Cabin.Zestawienie.NewRow();
                R[0] = "Szyba";
                R[1] = (Szyba.Wys + "x"+Math.Max(Szyba.Sz,Szyba.SzG)+"x6");
                R[2] = "szt.";
                R[3] = "1";
                R[4] = Typ;
                Cabin.Zestawienie.Rows.Add(R);
            }

            void ToCSV(DataTable dtDataTable, string strFilePath)
            {
                StreamWriter sw = new StreamWriter(strFilePath, false,Encoding.UTF8);
                //headers    
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    sw.Write(dtDataTable.Columns[i]);
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(";");
                    }
                }
                sw.Write(sw.NewLine);
                foreach (DataRow dr in dtDataTable.Rows)
                {
                    for (int i = 0; i < dtDataTable.Columns.Count; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            string value = dr[i].ToString();
                            if (value.Contains(','))
                            {
                                value = String.Format("\"{0}\"", value);
                                sw.Write(value);
                            }
                            else
                            {
                                sw.Write(dr[i].ToString());
                            }
                        }
                        if (i < dtDataTable.Columns.Count - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
            }
        }
        private void SortLK()
        {
            LK = LK.OrderBy(x => x.Indeks).ToList();
            for (int i = 0; i < LK.Count - 1; i++)
            {
                if (LK[i].Indeks == LK[i + 1].Indeks)
                {
                    LK[i].Ilosc += LK[i + 1].Ilosc;
                    LK.Remove(LK[i + 1]);
                }
            }
        }

        private string ChangeLetterToNumber(object s)
        {
            return s.ToString().Replace("H", Wys.ToString()).Replace("B", Szer[0].ToString()).Replace("C", Szer[1].ToString()).Replace("ob", LS[0].OdSz.ToString()).Replace("oc", LS[1].OdSz.ToString());
        }
        public int GetFromString(object s)
        {
            string ss = ChangeLetterToNumber(s);

            int.TryParse(new DataTable().Compute(ss.ToString(), "").ToString(), out int val);
            return val;
        }
        public int GetFromString(object[] s, char ch)
        {
            int ans = ch == '*' ? 1 : 0;
            s.ToList().ForEach(x =>
            {
                string ss = ChangeLetterToNumber(x);
                int.TryParse(new DataTable().Compute(ss.ToString(), "").ToString(), out int val);
                if (ch == '*') ans *= val;
                else ans += val;
            });
            return ans;
        }
    }

    class Komponent
    {
        public string Typ { get; set; }
        public string Indeks { get; set; }
        public int Ilosc { get; set; }
        public int Dlugosc { get; set; }
        public DataRow R { get; private set; }

        public void GetDataRow()
        {
            DataRow OldR = Dane.Dane.DS.Tables["Komponenty"].AsEnumerable().Where(x => x["NN"].ToString() == Indeks).First();
            R = Cabin.Zestawienie.NewRow();
            R[0] = Indeks;
            R[1] = OldR["Nazwa"].ToString();
            R[2] = OldR["jm"].ToString();
            R[3] = Ilosc;
            R[4] = Dlugosc != 0 ? Dlugosc.ToString() : "";
            Cabin.Zestawienie.Rows.Add(R);
        }
    }

    class Szyba
    {
        public string Strona { get; set; }
        public int Wys { get; set; }
        public int Sz { get; set; }
        public int SzG { get; set; }
        public int OdSz { get; set; }

        public int[] SlantDim { get; set; }
        public int[] CutDim { get; set; }

        public int[] OdSzNom { get; set; }
        public bool OdSzB { get; set; }
        public string Adres { get; set; }
        public string Nazwa { get; set; }
        public void GetOdchylka()
        {
            if (OdSz >= OdSzNom[2] && OdSz <= OdSzNom[1])
            { SzG = Sz; }
            else
            {
                if (OdSzB)
                { SzG = Sz + OdSz; }
                else
                {
                    Sz -= (OdSz < OdSzNom[1]) ? OdSzNom[2] : (OdSz > OdSzNom[2]) ? OdSzNom[1] : 0;
                    SzG = Sz + ((Math.Abs(OdSz) > OdSzNom[0]) ? OdSz : 0);
                }
            }
        }
    }
}
