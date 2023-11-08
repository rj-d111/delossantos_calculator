﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_los_Santos_Calculator.Custom_Class
{

        public class RoundButton : Button
        {
            //Fields
            [Category("Customized Round Button")]
            public int borderSize { get; set; } = 0;
            [Category("Customized Round Button")]
            public int BorderRadius { get; set; } = 20;
            [Category("Customized Round Button")]
            public Color BorderColor { get; set; } = Color.Transparent;

            [Category("Customized Round Button")]
            public Color BackgroundColor { get; set; }
            [Category("Customized Round Button")]
            public Color TextColor { get; set; }

            public RoundButton()
            {
                this.FlatStyle = FlatStyle.Flat;
                this.FlatAppearance.BorderSize = 0;
                this.Size = new Size(150, 40);
                this.BackColor = Color.MediumSlateBlue;
                this.ForeColor = Color.White;
                this.Resize += new EventHandler(Button_Resize);
                this.Font = new Font("Segoe UI", 14);

            }
            private void Button_Resize(object sender, EventArgs e)
            {
                if (BorderRadius > this.Height)
                    BorderRadius = this.Height;
            }
            //Methods
            private GraphicsPath GetFigurePath(Rectangle rect, float radius)
            {
                GraphicsPath path = new GraphicsPath();
                float curveSize = radius * 2F;
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
                return path;
            }
            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
                Rectangle rectSurface = this.ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
                int smoothSize = 2;
                if (borderSize > 0)
                    smoothSize = borderSize;
                if (BorderRadius > 2) //Rounded button
                {
                    using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - borderSize))
                    using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                    using (Pen penBorder = new Pen(BorderColor, borderSize))
                    {
                        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        //Button surface
                        this.Region = new Region(pathSurface);
                        //Draw surface border for HD result
                        pevent.Graphics.DrawPath(penSurface, pathSurface);
                        //Button border                    
                        if (borderSize >= 1)
                            //Draw control border
                            pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
                else //Normal button
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.None;
                    //Button surface
                    this.Region = new Region(rectSurface);
                    //Button border
                    if (borderSize >= 1)
                    {
                        using (Pen penBorder = new Pen(BorderColor, borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Inset;
                            pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                }
            }
            protected override void OnHandleCreated(EventArgs e)
            {
                base.OnHandleCreated(e);
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
            private void Container_BackColorChanged(object sender, EventArgs e)
            {
                this.Invalidate();
            }
        }
    }

