using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenGL;
using System.Runtime.InteropServices; 

namespace myOpenGL
{
    public partial class Form1 : Form
    {
        cOGL cGL;

        public Form1()
        {

            InitializeComponent();
            cGL = new cOGL(panel1);
            //apply the bars values as cGL.ScrollValue[..] properties 
                                         //!!!
            hScrollBarScroll(hScrollBar1, null);
            hScrollBarScroll(hScrollBar2, null);
            hScrollBarScroll(hScrollBar3, null);
            hScrollBarScroll(hScrollBar4, null);
            hScrollBarScroll(hScrollBar5, null);
            hScrollBarScroll(hScrollBar6, null);
            hScrollBarScroll(hScrollBar7, null);
            hScrollBarScroll(hScrollBar8, null);
            hScrollBarScroll(hScrollBar9, null);
            hScrollBarScroll(hScrollBar11, null);
            hScrollBarScroll(hScrollBar12, null);
            hScrollBarScroll(hScrollBar13, null);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cGL.Draw();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            //cGL.OnResize();
        }

        public float[] oldPos = new float[7];

        private void numericUpDownValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nUD = (NumericUpDown)sender;
            int i = int.Parse(nUD.Name.Substring(nUD.Name.Length - 1));
            int pos = (int)nUD.Value;
            switch (i)
            {
                case 1:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.xShift += 0.25f;
                        cGL.intOptionC = 4;
                    }
                    else
                    {
                        cGL.xShift -= 0.25f;
                        cGL.intOptionC = -4;
                    }
                    break;
                case 2:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.yShift += 0.25f;
                        cGL.intOptionC = 5;
                    }
                    else
                    {
                        cGL.yShift -= 0.25f;
                        cGL.intOptionC = -5;
                    }
                    break;
                case 3:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.zShift += 0.25f;
                        cGL.intOptionC = 6;
                    }
                    else
                    {
                        cGL.zShift -= 0.25f;
                        cGL.intOptionC = -6;
                    }
                    break;
                case 4:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.xAngle += 5;
                        cGL.intOptionC = 1;
                    }
                    else
                    {
                        cGL.xAngle -= 5;
                        cGL.intOptionC = -1;
                    }
                    break;
                case 5:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.yAngle += 5;
                        cGL.intOptionC = 2;
                    }
                    else
                    {
                        cGL.yAngle -= 5;
                        cGL.intOptionC = -2;
                    }
                    break;
                case 6:
                    if (pos > oldPos[i - 1])
                    {
                        cGL.zAngle += 5;
                        cGL.intOptionC = 3;
                    }
                    else
                    {
                        cGL.zAngle -= 5;
                        cGL.intOptionC = -3;
                    }
                    break;
            }
            cGL.Draw();
            oldPos[i - 1] = pos;
            cGL.intOptionC = 0;

        }

        private void hScrollBarScroll(object sender, ScrollEventArgs e)
        {
            cGL.intOptionC = 0;
            HScrollBar hb = (HScrollBar)sender;
            int n = int.Parse(hb.Name.Substring(10));
            cGL.ScrollValue[n - 1] = (hb.Value - 100) / 10.0f;
            if (e != null)
                cGL.Draw();
        }

       
        int oldPos7 = 0;
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown7.Value;
            if (pos > oldPos7)
                cGL.ROBOT_angle += 10;
            else
                cGL.ROBOT_angle -= 10;
            cGL.Draw();
            oldPos7 = pos;
        }

        int oldPos8 = 0;
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown8.Value;

            if (pos > oldPos8)
            {
                if (45 >= cGL.SHOULDER_angle + 10)
                    cGL.SHOULDER_angle += 10;
            }
            else
            {
                if (cGL.SHOULDER_angle - 10 >= -45)
                    cGL.SHOULDER_angle -= 10;
            }

            cGL.CreateRobotList();
            cGL.CreateRobotListforShade();
            cGL.Draw();
            oldPos8 = pos;
        }

        int oldPos9 = 0;
        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown9.Value;
            if (pos > oldPos9)
            {
                if (90 >= cGL.ARM_angle + 10)
                    cGL.ARM_angle += 10;
            }
            else
            {
                if (cGL.ARM_angle - 10 >= -90)
                    cGL.ARM_angle -= 10;
            }
            cGL.CreateRobotList();
            cGL.CreateRobotListforShade();
            cGL.Draw();
            oldPos9 = pos;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch (e.KeyChar)
            {
                case 'x':
                    cGL.move[0] -= 0.25f;

                    if (cGL.check_distance()&& cGL.check_border())
                    {
                        cGL.wall2[0, 1] = cGL.wall2[1, 1] = cGL.wall2[2, 1] += -0.25f;
                        cGL.cubeW4[0, 1] = cGL.cubeW4[1, 1] = cGL.cubeW4[2, 1] += -0.25f;

                        cGL.wall4[0, 1] = cGL.wall4[1, 1] = cGL.wall4[2, 1] -= -0.25f;
                        cGL.cubeW2[0, 1] = cGL.cubeW2[1, 1] = cGL.cubeW2[2, 1] -= -0.25f;
                    }
                    else
                        cGL.move[0] += 0.25f;

                    break;
                case 'X':
                    cGL.move[0] += 0.25f;
                    if (cGL.check_distance() && cGL.check_border())
                    {
                        cGL.wall2[0, 1] = cGL.wall2[1, 1] = cGL.wall2[2, 1] += 0.25f;
                        cGL.cubeW4[0, 1] = cGL.cubeW4[1, 1] = cGL.cubeW4[2, 1] += 0.25f;

                        cGL.wall4[0, 1] = cGL.wall4[1, 1] = cGL.wall4[2, 1] -= 0.25f;
                        cGL.cubeW2[0, 1] = cGL.cubeW2[1, 1] = cGL.cubeW2[2, 1] -= 0.25f;
                    }
                    else
                        cGL.move[0] -= 0.25f;
                    break;
                
                case 'y':
                    cGL.move[1] -= 0.25f;
                    if (cGL.check_distance() && cGL.check_border())
                    {
                        cGL.wall[0, 1] = cGL.wall[1, 1] = cGL.wall[2, 1] -= -0.25f;
                        cGL.cubeW[0, 1] = cGL.cubeW[1, 1] = cGL.cubeW[2, 1] -= -0.25f;

                        cGL.wall3[0, 1] = cGL.wall3[1, 1] = cGL.wall3[2, 1] += -0.25f;
                        cGL.cubeW3[0, 1] = cGL.cubeW3[1, 1] = cGL.cubeW3[2, 1] += -0.25f;
                    }
                    else
                        cGL.move[1] += 0.25f;
                    break;
                
                case 'Y':
                    cGL.move[1] += 0.25f;
                    if (cGL.check_distance() && cGL.check_border())
                    {
                        cGL.wall[0, 1] = cGL.wall[1, 1] = cGL.wall[2, 1] -= 0.25f;
                        cGL.cubeW[0, 1] = cGL.cubeW[1, 1] = cGL.cubeW[2, 1] -= 0.25f;

                       cGL.wall3[0, 1] = cGL.wall3[1, 1] = cGL.wall3[2, 1] += 0.25f;
                       cGL.cubeW3[0, 1] = cGL.cubeW3[1, 1] = cGL.cubeW3[2, 1] += 0.25f;
                    }
                    else
                        cGL.move[1] -= 0.25f;
                    break;
                
            }
            cGL.Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerRUN.Enabled = !timerRUN.Enabled;
            if (timerRUN.Enabled)
                button3.Text = "stop";
            else
                button3.Text = "run";
        }

        private void timerRUN_Tick(object sender, EventArgs e)
        {
            
            timerRUN.Interval = 50;
            float dx = (float)cGL.point[0] - (float)cGL.move[0];
            float dy = (float)cGL.point[1] - (float)cGL.move[1];
           
            if (!cGL.cought)
            {


                if (3 * cGL.r + 0.5 + 1 < Math.Sqrt(Math.Pow(cGL.move[0] - cGL.point[0], 2) + Math.Sqrt(Math.Pow(cGL.move[1] - cGL.point[1], 2))))
                {

                    cGL.move[0] += dx / Math.Abs(dx) * 0.25f;
                    dx += dx / Math.Abs(dx) * 0.25f;
                    cGL.wall2[0, 1] = cGL.wall2[1, 1] = cGL.wall2[2, 1] += dx / Math.Abs(dx) * 0.25f;
                    cGL.wall4[0, 1] = cGL.wall4[1, 1] = cGL.wall4[2, 1] -= dx / Math.Abs(dx) * 0.25f;

                }

                if (3 * cGL.r + 0.5 + 1 < Math.Sqrt(Math.Pow(cGL.move[0] - cGL.point[0], 2) + Math.Sqrt(Math.Pow(cGL.move[1] - cGL.point[1], 2))))
                {
                    cGL.move[1] += dy / Math.Abs(dy) * 0.25f;
                    dy += dy / Math.Abs(dy) * 0.25f;
                    cGL.wall[0, 1] = cGL.wall[1, 1] = cGL.wall[2, 1] -= dy / Math.Abs(dy) * 0.25f;
                    cGL.wall3[0, 1] = cGL.wall3[1, 1] = cGL.wall3[2, 1] += dy / Math.Abs(dy) * 0.25f;

                }

            }
            cGL.Draw();
            
          }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
