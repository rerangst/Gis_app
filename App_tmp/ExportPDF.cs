using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace App_tmp
{
    class ExportPDF
    {
        public void ExportToPdf(System.Data.DataTable dt)
        {
            Document document = new Document(PageSize.A4);
            EditHeaderFooter pageEventHelper = new EditHeaderFooter();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("D://sample.pdf", FileMode.Create));
            writer.PageEvent = pageEventHelper;
            document.Open();
            WriteTheTable(writer, document, dt);
            document.Close();
            writer.Close();
        }
        void WriteTheTable(PdfWriter writer, Document document, System.Data.DataTable dataTable)
        {
            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);
            //Add line break
            document.Add(new Chunk("\n"));
            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(dataTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(table);
        }
    }
    class EditHeaderFooter : PdfPageEventHelper
    {
        PdfContentByte cb;
        PdfTemplate template;
        BaseFont bFontFooter = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            cb = writer.DirectContent;
            template = cb.CreateTemplate(50, 50);

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("rg_tinh".ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            //Full path to the Unicode Arial file
            string Times_New_Roman = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(Times_New_Roman, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, iTextSharp.text.BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Tác giả : user... ", fntAuthor));
            prgAuthor.Add(new Chunk("\nNgày tạo : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            //base.OnEndPage(writer, document);

            ////Pagenumber
            int pageN = writer.PageNumber;
            String pageText = "Page " + pageN.ToString() + " of "; //+document.PageNumber.ToString();
            float pageTextLen = bFontFooter.GetWidthPoint(pageText, 8);
            iTextSharp.text.Rectangle pageSize = document.PageSize;
            cb.SetRGBColorFill(100, 100, 100);
            cb.BeginText();
            cb.SetFontAndSize(bFontFooter, 8);
            cb.SetTextMatrix(pageSize.Width - document.RightMargin - pageTextLen, pageSize.GetBottom(document.BottomMargin) / 2);
            cb.ShowText(pageText);
            cb.EndText();
            ////Text app
            String appText = "Creat by ";
            cb.BeginText();
            cb.SetFontAndSize(bFontFooter, 8);
            cb.SetTextMatrix(document.LeftMargin, pageSize.GetBottom(document.BottomMargin) / 2);
            cb.ShowText(appText);
            cb.EndText();

            cb.AddTemplate(template, pageSize.Width - document.RightMargin, pageSize.GetBottom(document.BottomMargin) / 2);

        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
            template.BeginText();
            template.SetFontAndSize(bFontFooter, 8);
            template.SetTextMatrix(0, 0);
            template.ShowText("" + (writer.PageNumber));
            template.EndText();
        }
    }
}
