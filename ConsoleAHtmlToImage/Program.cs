using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace ConsoleAHtmlToImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string strIMB = "FFTTDAADTTADTFDDFDDTFAFATDTDDFDAFDADDADDAFAAAFTTFTFDTFAAADADDDFDF";
            string part1 = @"  
                <!DOCTYPE html>  
                    <html>  
                        <head>  
                            <style>  
                                p.uspsBarCode {font-family: USPSIMBCompact; font-size:16pt}
                          </style>  
                         </head>  
                    <body>  
                      <p class='uspsBarCode'>";
            string part2 = @"</p></body> </html> ";
            string source = part1 + strIMB + part2;

            Bitmap m_Bitmap = new Bitmap(350, 60);
            m_Bitmap.SetResolution(1500, 1500);
            PointF point = new PointF(0, 0);
            SizeF maxSize = new System.Drawing.SizeF(350, 60);           
            HtmlRender.Render(Graphics.FromImage(m_Bitmap),
                                            source,
                                            point, maxSize);


            //m_Bitmap.Save(@"C:\temp\Test.bmp");
            m_Bitmap.Save(@"C:\temp\Test.Png", ImageFormat.Png);
        }
    }
}
