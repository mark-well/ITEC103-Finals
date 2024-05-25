using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ITEC103_Finals
{
    public class Receipt
    {
        public static void GenerateReceipt(List<CartItem> items, int itemTotalPrice, int customerCash, int _exchange, PrintDocument receiptDocument, PrintPageEventArgs e)
        {
            int paperWidth = receiptDocument.DefaultPageSettings.PaperSize.Width;
            int paperHeight = receiptDocument.DefaultPageSettings.PaperSize.Height;

            int smallFont = 8;
            int mediumFont = 10;
            int largeFont = 14;

            //TEXT
            string subtotal = $"P{itemTotalPrice}";
            string cash = $"P{customerCash}";
            string exchange = $"P{_exchange}";
            string text0 = "MicroPOS";
            string text1 = "LSPU Siniloan, Laguna";
            string text2 = "Food and Beverages";
            string text3 = "Name";
            string text4 = "Qty.";
            string text5 = "Price";
            string text6 = "Date: mm/dd/yyyy";
            string text7 = "Exchange:";
            string text8 = "Cash:";
            string text9 = "Sub total:";

            //=== HEADER ===
            e.Graphics.DrawString(text0, new Font("Arial", largeFont, FontStyle.Bold), Brushes.Black, new Point((paperWidth / 2) - (GetTextWidth(text0, largeFont) / 2), 20));
            e.Graphics.DrawString(text1, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point((paperWidth / 2) - (GetTextWidth(text1, mediumFont) / 2), 60));
            e.Graphics.DrawString(text2, new Font("Arial", smallFont, FontStyle.Regular), Brushes.Black, new Point((paperWidth / 2) - (GetTextWidth(text2, smallFont) / 2), 80));
            e.Graphics.DrawString("-----------------------------------------------------------", new Font("Arial", largeFont, FontStyle.Regular), Brushes.Black, new Point(0, 90));
            e.Graphics.DrawString(text3, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(20, 120));
            e.Graphics.DrawString(text4, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth-125, 120));
            e.Graphics.DrawString(text5, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth-GetTextWidth(text5, mediumFont)-20, 120));

            //Item goes Here
            int yPos = 160;
            int yGap = 15;
            foreach (CartItem item in items)
            {
                yPos += yGap;

                e.Graphics.DrawString(item.itemName, new Font("Arial", smallFont, FontStyle.Regular), Brushes.Black, new Point(20, yPos));
                e.Graphics.DrawString($"{item.quantity}x", new Font("Arial", smallFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth - 115, yPos));
                e.Graphics.DrawString($"P{item.itemPrice}", new Font("Arial", smallFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth - GetTextWidth("P25", smallFont) - 30, yPos));
            }

            //=== FOOTER ===
            e.Graphics.DrawString("-----------------------------------------------------------", new Font("Arial", largeFont, FontStyle.Regular), Brushes.Black, new Point(0, paperHeight - 155));
            e.Graphics.DrawString(text9, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(20, paperHeight-130));
            e.Graphics.DrawString(subtotal, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth-GetTextWidth(subtotal,mediumFont)-20, paperHeight-130));
            e.Graphics.DrawString(text8, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(20, paperHeight-115));
            e.Graphics.DrawString(cash, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth - GetTextWidth(cash, mediumFont) - 20, paperHeight - 115));
            e.Graphics.DrawString(text7, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(20, paperHeight-100));
            e.Graphics.DrawString(exchange, new Font("Arial", mediumFont, FontStyle.Regular), Brushes.Black, new Point(paperWidth - GetTextWidth(exchange, mediumFont) - 20, paperHeight - 100));
            e.Graphics.DrawString(text6, new Font("Arial", smallFont, FontStyle.Regular), Brushes.Black, new Point(20, paperHeight-50));
            e.Graphics.DrawString("-----------------------------------------------------------", new Font("Arial", largeFont, FontStyle.Regular), Brushes.Black, new Point(0, paperHeight-40));

        }

        public static void PrintReceipt(PrintDocument receiptDocument, PrintPreviewDialog receiptPreviewDialog)
        {
            receiptPreviewDialog.Document = receiptDocument;
            receiptDocument.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 285, 600);
            receiptPreviewDialog.ShowDialog();
        }

        public static int GetTextWidth(string text, int fontSize)
        {
            if (text == null) return 0;
            double textWidth = 0;

            if (fontSize == 14)
            {
                textWidth = fontSize * 0.8 * text.Length;
            } else if (fontSize == 8)
            {
                textWidth = fontSize * 0.7 * text.Length;
            }
            else if (fontSize == 10)
            {
                textWidth = fontSize * 0.7 * text.Length;
            }
            else
            {
                textWidth = fontSize * 0.7 * text.Length;
            }

            return Convert.ToInt32(textWidth);
        }
    }
}
