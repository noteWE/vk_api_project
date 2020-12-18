using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VK_API
{
    public class VK_card : Control
    {
        #region --- Variables ---

        // Высота шторки
        private float CurtainHeight;
        private bool MouseEntered = false;
        private bool MousePressed = false;
        #endregion

        #region -- Props ---

        //Настройка заголовка(текст, шрифт, цвет шрифта)
        public string TextHeader { get; set; } = "Header";
        public Font FontHeader { get; set; } = new Font("Verdana", 12F, FontStyle.Bold);
        public Color ForeColorHeader { get; set; } = Color.White;

        //Настройка описания(текст, шрифт, цвет шрифта)
        public string TextDescription { get; set; } = "Your text for description";
        public Font FontDescription { get; set; } = new Font("Verdana", 8.25F, FontStyle.Regular);
        public Color ForeColorDescription { get; set; } = Color.Black;

        //Настройка цвета шрифта
        public Color BackColorCurtain { get; set; } = Color.AliceBlue;

        #endregion
        public VK_card()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(250, 200);
            Font = new Font("Verdana", 9F, FontStyle.Regular);
            BackColor = Color.White;

            CurtainHeight = Height - 60;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int) CurtainHeight);

            // Fon
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            // Shtorka
            graph.DrawRectangle(new Pen(BackColorCurtain), rectCurtain);
            graph.FillRectangle(new SolidBrush(BackColorCurtain), rectCurtain);

            // Obvodka
            graph.DrawRectangle(new Pen(BackColor), rect);

            graph.DrawString(TextDescription, Font, new SolidBrush(ForeColor), 15, Height - 37);
            graph.DrawString(TextHeader, FontHeader, new SolidBrush(ForeColorHeader),
                new Rectangle(15,15, rectCurtain.Width, rectCurtain.Height));

            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            }

            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (Height <= 100)
            {
                Height = 100;
            }
            if (Width <= 100)
            {
                Width = 100;
            }

            CurtainHeight = Height - 60;
            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
            Invalidate();
        }
    }
}
