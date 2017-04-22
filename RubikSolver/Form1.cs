using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikSolver {
    public partial class Form1 : Form {
        static public DS Cube = new DS();
        String solve = "";
        int index = 0;
        bool forword = true;
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// 随机打乱魔方
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        private String Get_rand_code(int step) {
            Random rand = new Random();
            String code = "";
            String one = "UDLRFB";
            String two = "012";
            for(int i = 0; i < step; i++) {
                code += one[rand.Next(0, 6)];
                code += two[rand.Next(0, 3)];
            }
            return code;
        }

        /// <summary>
        /// 向后退一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            if(solve.Length > 0) {
                if(index > 1) {
                    index -= 2;
                    label2.Text = solve[index].ToString();
                    label2.Text += solve[index + 1].ToString();
                    forword = false;
                    runstep(index);
                }
            }
        }

        /// <summary>
        /// 向前进一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            if(solve.Length > 0) {
                if(index <= solve.Length - 2) {
                    forword = true;
                    runstep(index);
                    index += 2;
                    if(index == solve.Length) {
                        label2.Text = "已完成！";
                    }
                    else {
                        label2.Text = solve[index].ToString();
                        label2.Text += solve[index + 1].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 动一条指令
        /// </summary>
        /// <param name="codes">指令串</param>
        private void runstepts(String codes) {
            int len = codes.Length;
            for(; index <= len - 2; index += 2) {
                //debug.Text += index + "\r\n";
                runstep(index);
            }
            //debug.Text += index + "\r\n";
        }

        /// <summary>
        /// 动一步
        /// </summary>
        /// <param name="i">指令串中下一步变换的位置</param>
        private void runstep(int i) {
            if(forword) {
                if(solve[i] == 'U') {
                    if(solve[i + 1] == '0') {
                        Cube.U0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.U1();
                        label2.Text = "U1";
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.U2();
                        label2.Text = "U2";
                    }
                }
                else if(solve[i] == 'D') {
                    if(solve[i + 1] == '0') {
                        Cube.D0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.D1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.D2();
                    }
                }
                else if(solve[i] == 'L') {
                    if(solve[i + 1] == '0') {
                        Cube.L0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.L1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.L2();
                    }
                }
                else if(solve[i] == 'R') {
                    if(solve[i + 1] == '0') {
                        Cube.R0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.R1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.R2();
                    }
                }
                else if(solve[i] == 'F') {
                    if(solve[i + 1] == '0') {
                        Cube.F0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.F1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.F2();
                    }
                }
                else if(solve[i] == 'B') {
                    if(solve[i + 1] == '0') {
                        Cube.B0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.B1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.B2();
                    }
                }
                else if(solve[i] == 'x') {
                    if(solve[i + 1] == '0') {
                        Cube.x0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.x1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.x2();
                    }

                }
                else if(solve[i] == 'y') {
                    if(solve[i + 1] == '0') {
                        Cube.y0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.y1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.y2();
                    }

                }
                else if(solve[i] == 'z') {
                    if(solve[i + 1] == '0') {
                        Cube.z0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.z1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.z2();
                    }
                }
                else if(solve[i] == 'u') {
                    if(solve[i + 1] == '0') {
                        Cube.u0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.u1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.u2();
                    }
                }
                else if(solve[i] == 'd') {
                    if(solve[i + 1] == '0') {
                        Cube.d0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.d1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.d2();
                    }
                }
                else if(solve[i] == 'l') {
                    if(solve[i + 1] == '0') {
                        Cube.l0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.l1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.l2();
                    }
                }
                else if(solve[i] == 'r') {
                    if(solve[i + 1] == '0') {
                        Cube.r0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.r1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.r2();
                    }
                }
                else if(solve[i] == 'f') {
                    if(solve[i + 1] == '0') {
                        Cube.f0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.f1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.f2();
                    }
                }
                else if(solve[i] == 'b') {
                    if(solve[i + 1] == '0') {
                        Cube.b0();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.b1();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.b2();
                    }
                }
            }
            else {
                if(solve[i] == 'U') {
                    if(solve[i + 1] == '0') {
                        Cube.U1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.U0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.U2();
                    }
                }
                else if(solve[i] == 'D') {
                    if(solve[i + 1] == '0') {
                        Cube.D1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.D0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.D2();
                    }
                }
                else if(solve[i] == 'L') {
                    if(solve[i + 1] == '0') {
                        Cube.L1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.L0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.L2();
                    }
                }
                else if(solve[i] == 'R') {
                    if(solve[i + 1] == '0') {
                        Cube.R1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.R0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.R2();
                    }
                }
                else if(solve[i] == 'F') {
                    if(solve[i + 1] == '0') {
                        Cube.F1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.F0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.F2();
                    }
                }
                else if(solve[i] == 'B') {
                    if(solve[i + 1] == '0') {
                        Cube.B1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.B0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.B2();
                    }
                }
                else if(solve[i] == 'x') {
                    if(solve[i + 1] == '0') {
                        Cube.x1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.x0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.x2();
                    }

                }
                else if(solve[i] == 'y') {
                    if(solve[i + 1] == '0') {
                        Cube.y1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.y0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.y2();
                    }

                }
                else if(solve[i] == 'z') {
                    if(solve[i + 1] == '0') {
                        Cube.z1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.z0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.z2();
                    }
                }
                else if(solve[i] == 'u') {
                    if(solve[i + 1] == '0') {
                        Cube.u1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.u0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.u2();
                    }
                }
                else if(solve[i] == 'd') {
                    if(solve[i + 1] == '0') {
                        Cube.d1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.d0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.d2();
                    }
                }
                else if(solve[i] == 'l') {
                    if(solve[i + 1] == '0') {
                        Cube.l1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.l0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.l2();
                    }
                }
                else if(solve[i] == 'r') {
                    if(solve[i + 1] == '0') {
                        Cube.r1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.r0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.r2();
                    }
                }
                else if(solve[i] == 'f') {
                    if(solve[i + 1] == '0') {
                        Cube.f1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.f0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.f2();
                    }
                }
                else if(solve[i] == 'b') {
                    if(solve[i + 1] == '0') {
                        Cube.b1();
                    }
                    else if(solve[i + 1] == '1') {
                        Cube.b0();
                    }
                    else if(solve[i + 1] == '2') {
                        Cube.b2();
                    }
                }
            }
            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        /// <summary>
        /// 画平面图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle[,,] face = new Rectangle[6, 3, 3];
            int[] offsetx = { 260, 80, 170, 260, 350, 260 };
            int[] offsety = { 195, 105, 105, 105, 105, 15 };


            for(int i = 0; i < 6; i++) {
                for(int j = 0; j < 3; j++) {
                    for(int k = 0; k < 3; k++) {
                        face[i, j, k] = new Rectangle(new Point(offsetx[i] + 30 * k, offsety[i] + 30 * j), new Size(29, 29));
                        fillColor(g, face[i, j, k], Cube.CubeColor[i, 1 + j * 3 + k]);
                    }
                }
            }
        }

        /// <summary>
        /// 填充矩形框的颜色
        /// </summary>
        /// <param name="g">绘图图面</param>
        /// <param name="rectangle">矩形</param>
        /// <param name="v">颜色</param>
        private void fillColor(Graphics g, Rectangle rectangle, char v) {
            if(v == 'w') {
                g.FillRectangle(Brushes.White, rectangle);
            }
            else if(v == 'b') {
                g.FillRectangle(Brushes.Blue, rectangle);
            }
            else if(v == 'r') {
                g.FillRectangle(Brushes.Red, rectangle);
            }
            else if(v == 'g') {
                g.FillRectangle(Brushes.Green, rectangle);
            }
            else if(v == 'o') {
                g.FillRectangle(Brushes.Orange, rectangle);
            }
            else if(v == 'y') {
                g.FillRectangle(Brushes.Yellow, rectangle);
            }
        }

        /// <summary>
        /// 画立体图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Parallelogram[,] face0 = new Parallelogram[3, 3];
            Rectangle[,] face1 = new Rectangle[3, 3];
            Parallelogram2[,] face2 = new Parallelogram2[3, 3];
            Rectangle[,] face3 = new Rectangle[3, 3];
            Parallelogram2[,] face4 = new Parallelogram2[3, 3];
            Parallelogram[,] face5 = new Parallelogram[3, 3];

            for(int i = 2; i >= 0; i--) {
                int offset = (3 - i) * 12;
                for(int j = 0; j < 3; j++) {
                    face0[i, j] = new Parallelogram(new Point(74 + 30 * j + offset, 260 + 12 * i), 30, 12);
                    face0[i, j].FillParallelogram(g, Cube.CubeColor[0, 1 + (2 - i) * 3 + j]);
                }
            }

            for(int i = 0; i < 3; i++) {
                for(int j = 2; j >= 0; j--) {
                    face1[i, j] = new Rectangle(new Point(217 + 30 * j, 15 + 30 * i), new Size(29, 29));
                    fillColor(g, face1[i, j], Cube.CubeColor[1, 1 + i * 3 + (2 - j)]);
                }
            }

            for(int i = 0; i < 3; i++) {
                for(int j = 2; j >= 0; j--) {
                    int offset = (3 - j) * 12;
                    face2[i, j] = new Parallelogram2(new Point(34 + 12 * j, 110 + 30 * i + offset), 30, 12);
                    face2[i, j].FillParallelogram(g, Cube.CubeColor[2, 1 + i * 3 + (2 - j)]);
                }
            }

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    face3[i, j] = new Rectangle(new Point(86 + 30 * j, 146 + 30 * i), new Size(29, 29));
                    fillColor(g, face3[i, j], Cube.CubeColor[3, 1 + i * 3 + j]);
                }
            }

            for(int i = 0; i < 3; i++) {
                for(int j = 0; j < 3; j++) {
                    int offset = j * 12;
                    face4[i, j] = new Parallelogram2(new Point(176 + 12 * j, 146 + 30 * i - offset), 30, 12);
                    face4[i, j].FillParallelogram(g, Cube.CubeColor[4, 1 + i * 3 + j]);
                }
            }

            for(int i = 0; i < 3; i++) {
                int offset = i * 12;
                for(int j = 0; j < 3; j++) {
                    face5[i, j] = new Parallelogram(new Point(110 + 30 * j - offset, 122 + 12 * i), 30, 12);
                    face5[i, j].FillParallelogram(g, Cube.CubeColor[5, 1 + i * 3 + j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Location = new Point(200, 20);         ///设置窗口位置
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            pictureBox2.Paint += new PaintEventHandler(pictureBox2_Paint);

            solve = Get_rand_code(20);
            runstepts(solve);
            debug.Text = solve;
            debug.Text += "\r\n";
            index = 0;
 
            solve = "";                             ///初始化解决方案
            SolveIt si = new SolveIt(Cube.CubeColor);   ///生成解决方案
            solve = si.answer;                      ///赋值解决方案

            index = solve.Length;                   ///操作指针移动到最后，
            debug.Text += si.debug;

            debug.Text += "answer = " + solve;

            if(index == solve.Length) {
                label2.Text = "已完成！";
            }
            else {
                label2.Text = solve[index].ToString();
                label2.Text += solve[index + 1].ToString();
            }
        }

    }

    public class DS {
        public Char[,] CubeColor = new Char[6, 10] {
            {'t','w','w','w','w','w','w','w','w','w'},
            {'t','b','b','b','b','b','b','b','b','b'},
            {'t','r','r','r','r','r','r','r','r','r'},
            {'t','g','g','g','g','g','g','g','g','g'},
            {'t','o','o','o','o','o','o','o','o','o'},
            {'t','y','y','y','y','y','y','y','y','y'}
        };

        public void U0() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;
        }
        public void U1() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 7];
            CubeColor[5, 7] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 4];
            CubeColor[5, 4] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;
        }
        public void U2() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 9];
            CubeColor[5, 9] = temp;
            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;
            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;
            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = temp;
            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;
        }
        public void R0() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;
        }
        public void R1() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;
        }
        public void R2() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;
            temp = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;
            temp = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;
        }
        public void F0() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;
        }
        public void F1() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;
        }
        public void F2() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;
            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 8];
            CubeColor[3, 8] = temp;
            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;
            temp = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;
        }
        public void D0() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;
        }
        public void D1() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;
        }
        public void D2() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;
            temp = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;
        }
        public void L0() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;
        }
        public void L1() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;
        }
        public void L2() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;
            temp = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;
            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;
        }
        public void B0() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;
        }
        public void B1() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;
        }
        public void B2() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;
            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;
            temp = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[5, 1];
            CubeColor[5, 1] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;
        }
        public void x0() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;

            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;
        }
        public void x1() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;

            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;
        }
        public void x2() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;
            temp = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;
            temp = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;

            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;
            temp = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;
            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = temp;
            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;
        }
        public void y0() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;



        }
        public void y1() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 7];
            CubeColor[5, 7] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 4];
            CubeColor[5, 4] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

        }
        public void y2() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 9];
            CubeColor[5, 9] = temp;
            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;
            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;
            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = temp;
            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;
            temp = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;
            temp = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;
            temp = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;
            temp = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

        }
        public void z0() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;


        }
        public void z1() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;


        }
        public void z2() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;
            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 8];
            CubeColor[3, 8] = temp;
            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;
            temp = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;
            temp = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;
            temp = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[5, 1];
            CubeColor[5, 1] = temp;
            temp = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;
            temp = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;


        }
        public void u0() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

        }
        public void u1() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[5, 7];
            CubeColor[5, 7] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[5, 4];
            CubeColor[5, 4] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

        }
        public void u2() {
            char temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[5, 9];
            CubeColor[5, 9] = temp;
            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;

            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;
            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[5, 6];
            CubeColor[5, 6] = temp;

            temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;
            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[3, 2];
            CubeColor[3, 2] = temp;
            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;
            temp = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;
            temp = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

        }
        public void r0() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;


        }
        public void r1() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;


        }
        public void r2() {
            char temp = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;
            temp = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;
            temp = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 1];
            CubeColor[1, 1] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = temp;
            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;


        }
        public void f0() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;


        }
        public void f1() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 3];
            CubeColor[3, 3] = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[4, 1];
            CubeColor[4, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;


        }
        public void f2() {
            char temp = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[3, 9];
            CubeColor[3, 9] = temp;
            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[3, 3];
            CubeColor[3, 3] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[3, 8];
            CubeColor[3, 8] = temp;
            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[3, 6];
            CubeColor[3, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[4, 1];
            CubeColor[4, 1] = temp;

            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;
            temp = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[5, 9];
            CubeColor[5, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;
            temp = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;
            temp = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;


        }
        public void d0() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;


        }
        public void d1() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 3];
            CubeColor[0, 3] = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;


        }
        public void d2() {
            char temp = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[0, 9];
            CubeColor[0, 9] = temp;
            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[0, 3];
            CubeColor[0, 3] = temp;

            temp = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;
            temp = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;

            temp = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[4, 7];
            CubeColor[4, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;

            temp = CubeColor[3, 9];
            CubeColor[3, 9] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;
            temp = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[4, 4];
            CubeColor[4, 4] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[3, 6];
            CubeColor[3, 6] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;
            temp = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;


        }
        public void l0() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;


        }
        public void l1() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 3];
            CubeColor[2, 3] = CubeColor[2, 9];
            CubeColor[2, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 6];
            CubeColor[2, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[3, 1];
            CubeColor[3, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[3, 4];
            CubeColor[3, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[3, 7];
            CubeColor[3, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[5, 8];
            CubeColor[5, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = CubeColor[5, 5];
            CubeColor[5, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[0, 2];
            CubeColor[0, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;


        }
        public void l2() {
            char temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[2, 9];
            CubeColor[2, 9] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[2, 3];
            CubeColor[2, 3] = temp;

            temp = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;
            temp = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[2, 6];
            CubeColor[2, 6] = temp;

            temp = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[0, 1];
            CubeColor[0, 1] = temp;
            temp = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[3, 1];
            CubeColor[3, 1] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[3, 4];
            CubeColor[3, 4] = temp;

            temp = CubeColor[5, 7];
            CubeColor[5, 7] = CubeColor[0, 7];
            CubeColor[0, 7] = temp;
            temp = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[3, 7];
            CubeColor[3, 7] = temp;

            temp = CubeColor[3, 8];
            CubeColor[3, 8] = CubeColor[1, 2];
            CubeColor[1, 2] = temp;
            temp = CubeColor[5, 8];
            CubeColor[5, 8] = CubeColor[0, 8];
            CubeColor[0, 8] = temp;

            temp = CubeColor[3, 5];
            CubeColor[3, 5] = CubeColor[1, 5];
            CubeColor[1, 5] = temp;
            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;

            temp = CubeColor[3, 2];
            CubeColor[3, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[0, 2];
            CubeColor[0, 2] = temp;


        }
        public void b0() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;


        }
        public void b1() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 3];
            CubeColor[1, 3] = CubeColor[1, 9];
            CubeColor[1, 9] = CubeColor[1, 7];
            CubeColor[1, 7] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 6];
            CubeColor[1, 6] = CubeColor[1, 8];
            CubeColor[1, 8] = CubeColor[1, 4];
            CubeColor[1, 4] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[4, 9];
            CubeColor[4, 9] = CubeColor[5, 3];
            CubeColor[5, 3] = CubeColor[2, 1];
            CubeColor[2, 1] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[4, 6];
            CubeColor[4, 6] = CubeColor[5, 2];
            CubeColor[5, 2] = CubeColor[2, 4];
            CubeColor[2, 4] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[4, 3];
            CubeColor[4, 3] = CubeColor[5, 1];
            CubeColor[5, 1] = CubeColor[2, 7];
            CubeColor[2, 7] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[2, 8];
            CubeColor[2, 8] = CubeColor[0, 6];
            CubeColor[0, 6] = CubeColor[4, 2];
            CubeColor[4, 2] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = CubeColor[4, 5];
            CubeColor[4, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[2, 2];
            CubeColor[2, 2] = CubeColor[0, 4];
            CubeColor[0, 4] = CubeColor[4, 8];
            CubeColor[4, 8] = temp;


        }
        public void b2() {
            char temp = CubeColor[1, 1];
            CubeColor[1, 1] = CubeColor[1, 9];
            CubeColor[1, 9] = temp;
            temp = CubeColor[1, 7];
            CubeColor[1, 7] = CubeColor[1, 3];
            CubeColor[1, 3] = temp;

            temp = CubeColor[1, 2];
            CubeColor[1, 2] = CubeColor[1, 8];
            CubeColor[1, 8] = temp;
            temp = CubeColor[1, 4];
            CubeColor[1, 4] = CubeColor[1, 6];
            CubeColor[1, 6] = temp;

            temp = CubeColor[0, 7];
            CubeColor[0, 7] = CubeColor[5, 3];
            CubeColor[5, 3] = temp;
            temp = CubeColor[2, 1];
            CubeColor[2, 1] = CubeColor[4, 9];
            CubeColor[4, 9] = temp;

            temp = CubeColor[0, 8];
            CubeColor[0, 8] = CubeColor[5, 2];
            CubeColor[5, 2] = temp;
            temp = CubeColor[2, 4];
            CubeColor[2, 4] = CubeColor[4, 6];
            CubeColor[4, 6] = temp;

            temp = CubeColor[0, 9];
            CubeColor[0, 9] = CubeColor[5, 1];
            CubeColor[5, 1] = temp;
            temp = CubeColor[2, 7];
            CubeColor[2, 7] = CubeColor[4, 3];
            CubeColor[4, 3] = temp;

            temp = CubeColor[5, 4];
            CubeColor[5, 4] = CubeColor[0, 6];
            CubeColor[0, 6] = temp;
            temp = CubeColor[4, 2];
            CubeColor[4, 2] = CubeColor[2, 8];
            CubeColor[2, 8] = temp;

            temp = CubeColor[5, 5];
            CubeColor[5, 5] = CubeColor[0, 5];
            CubeColor[0, 5] = temp;
            temp = CubeColor[4, 5];
            CubeColor[4, 5] = CubeColor[2, 5];
            CubeColor[2, 5] = temp;

            temp = CubeColor[5, 6];
            CubeColor[5, 6] = CubeColor[0, 4];
            CubeColor[0, 4] = temp;
            temp = CubeColor[4, 8];
            CubeColor[4, 8] = CubeColor[2, 2];
            CubeColor[2, 2] = temp;

        }
    }

    /// <summary>
    /// 平行四边形
    /// </summary>
    public class Parallelogram {
        Point Original = new Point();   ///原点
        int Base;                       ///底边长               
        int Height;                     ///高

        public Parallelogram(Point ori, int ba, int he) {   ///构造函数
            this.Original = ori;
            this.Base = ba;
            this.Height = he;
        }
        /// <summary>
        /// 给当前平行四边形染色
        /// </summary>
        /// <param name="g">画板</param>
        /// <param name="v">颜色代码</param>
        internal void FillParallelogram(Graphics g, char v) {
            for(int i = 0; i < Height - 1; i++) {
                Point start = new Point(Original.X + i, Original.Y - i);
                Point end = new Point(start.X + 28, start.Y);
                drawline(start, end, g, v);
            }
        }

        private void drawline(Point start, Point end, Graphics g, char v) {
            Pen pen = new Pen(Color.Yellow);
            if(v == 'w') {
                pen = new Pen(Color.White);
            }
            else if(v == 'b') {
                pen = new Pen(Color.Blue);
            }
            else if(v == 'r') {
                pen = new Pen(Color.Red);
            }
            else if(v == 'g') {
                pen = new Pen(Color.Green);
            }
            else if(v == 'o') {
                pen = new Pen(Color.Orange);
            }
            else if(v == 'y') {
                pen = new Pen(Color.Yellow);
            }

            g.DrawLine(pen, start, end);
        }
    }

    public class Parallelogram2 {
        Point Original = new Point();   ///原点
        int Base;                       ///底边长               
        int Height;                     ///高

        public Parallelogram2(Point ori, int ba, int he) {   ///构造函数
            this.Original = ori;
            this.Base = ba;
            this.Height = he;
        }
        /// <summary>
        /// 给当前平行四边形染色
        /// </summary>
        /// <param name="g">画板</param>
        /// <param name="v">颜色代码</param>
        internal void FillParallelogram(Graphics g, char v) {
            for(int i = 0; i < Height - 1; i++) {
                Point start = new Point(Original.X + i, Original.Y - i);
                Point end = new Point(start.X, start.Y + 28);
                drawline(start, end, g, v);
            }
        }

        private void drawline(Point start, Point end, Graphics g, char v) {
            Pen pen = new Pen(Color.Yellow);
            if(v == 'w') {
                pen = new Pen(Color.White);
            }
            else if(v == 'b') {
                pen = new Pen(Color.Blue);
            }
            else if(v == 'r') {
                pen = new Pen(Color.Red);
            }
            else if(v == 'g') {
                pen = new Pen(Color.Green);
            }
            else if(v == 'o') {
                pen = new Pen(Color.Orange);
            }
            else if(v == 'y') {
                pen = new Pen(Color.Yellow);
            }

            g.DrawLine(pen, start, end);
        }
    }

    public class SolveIt{
        public String answer = "";
        //static Char[,] Cubestate = new Char[6, 10];
        DS Cube_copy = new DS();
        Char[] uniformization = new Char[6];
        public String debug = "";

        int[] itemp1234 = { 1, 2, 3, 4 };
        int[] itemp1379 = { 1, 3, 7, 9 };
        int[] itemp2341 = { 2, 3, 4, 1 };
        int[] itemp2486 = { 2, 4, 8, 6 };
        int[] itemp3412 = { 3, 4, 1, 2 };
        int[] itemp4123 = { 4, 1, 2, 3 };
        int[] itemp7139 = { 7, 1, 3, 9 };
        int[] itemp7931 = { 7, 9, 3, 1 };
        int[] itemp8426 = { 8, 4, 2, 6 };
        int[] itemp9317 = { 9, 3, 1, 7 };
        char[] ctempBLFR = { 'B', 'L', 'F', 'R' };

        /// <summary>
        /// 还原魔方
        /// </summary>
        /// <param name="state">魔方的状态</param>
        public SolveIt(Char[,] state) {
            Cube_copy.CubeColor = state;
            uniformization[0] = Cube_copy.CubeColor[0, 5];
            uniformization[1] = Cube_copy.CubeColor[1, 5];
            uniformization[2] = Cube_copy.CubeColor[2, 5];
            uniformization[3] = Cube_copy.CubeColor[3, 5];
            uniformization[4] = Cube_copy.CubeColor[4, 5];
            uniformization[5] = Cube_copy.CubeColor[5, 5];
            for(int i = 0; i < 6; i++) {
                for(int j = 1; j < 10; j++) {
                    debug += Cube_copy.CubeColor[i, j];
                }
                debug += "\r\n";
            }
            step1_upcross();
            step2_T();
            step3_second();
            step4_new_cross();
            step5_top();
            step6_top_2();
            step7_top_3();
            //runstep("U2");
        }

        /// <summary>
        /// 还原魔方第一步：顶层十字
        /// </summary>
        public void step1_upcross() {
            for(int t = 0; t < 5; t++) {
                #region 顶层棱块
                for(int i = 0; i < 4; i++) {
                    /// 顶层棱块是白色
                    if(Cube_copy.CubeColor[5, itemp2486[i]] == uniformization[0]) {
                        int j = i;
                        /// 底层棱块是白色
                        int cnt = 0;
                        while(Cube_copy.CubeColor[0, itemp8426[j % 4]] == uniformization[0]) {
                            answer += "U1";
                            Cube_copy.U1();
                            j++;
                            cnt++;
                        }
                        answer += ctempBLFR[j % 4];
                        answer += "2";
                        runstep(ctempBLFR[j % 4] + "2");

                        for(int k = 0; k < cnt; k++) {
                            answer += "U0";
                            runstep("U0");
                        }
                    }
                }
                //debug += "\r\n";
                #endregion

                #region 侧边棱块1
                int[] itemp4123 = { 4, 1, 2, 3 };

                for(int i = 0; i < 4; i++) {
                    //debug += "当前判断[" + itemp4123[i] + "]面";
                    //debug += Cube_copy.CubeColor[itemp4123[i], 6] + "\r\n";
                    if(Cube_copy.CubeColor[itemp4123[i], 6] == uniformization[0]) {
                        //debug += "侧边棱块是白色...\r\n";
                        int j = i;
                        ///侧边棱块是白色
                        int cnt = 0;
                        while(Cube_copy.CubeColor[0, itemp8426[j % 4]] == uniformization[0]) {
                            answer += "u1";
                            Cube_copy.u1();
                            j++;
                            cnt++;
                        }
                        answer += ctempBLFR[j % 4];
                        answer += "1";
                        runstep(ctempBLFR[j % 4] + "1");

                        for(int k = 0; k < cnt; k++) {
                            answer += "u0";
                            runstep("u0");
                        }
                    }
                }

                #endregion

                #region 侧边棱块2
                for(int i = 0; i < 4; i++) {
                    //debug += "当前判断[" + itemp2341[i] + "]面";
                    //debug += Cube_copy.CubeColor[itemp2341[i], 4] + "\r\n";
                    if(Cube_copy.CubeColor[itemp2341[i], 4] == uniformization[0]) {
                        //debug += "侧边棱块是白色...\r\n";
                        int j = i;
                        ///侧边棱块是白色
                        int cnt = 0;
                        while(Cube_copy.CubeColor[0, itemp8426[j % 4]] == uniformization[0]) {
                            answer += "u1";
                            Cube_copy.u1();
                            j++;
                            cnt++;
                        }
                        answer += ctempBLFR[j % 4];
                        answer += "0";
                        runstep(ctempBLFR[j % 4] + "0");

                        for(int k = 0; k < cnt; k++) {
                            answer += "u0";
                            runstep("u0");
                        }
                    }
                }
                #endregion

                #region 顶层棱块
                for(int i = 0; i < 4; i++) {
                    if(Cube_copy.CubeColor[itemp1234[i], 8] == uniformization[0]) {
                        answer += ctempBLFR[i];
                        answer += "0";
                        runstep(ctempBLFR[i] + "0");
                    }
                }

                #endregion

                #region 顶层棱块
                for(int i = 0; i < 4; i++) {
                    ///顶层棱块是白色
                    if(Cube_copy.CubeColor[itemp1234[i], 2] == uniformization[0]) {
                        int j = i;
                        int cnt = 0;
                        while(Cube_copy.CubeColor[0, itemp8426[j % 4]] == uniformization[0]) {
                            answer += "U1";
                            runstep("U1");
                            j++;
                            cnt++;
                        }
                        answer += ctempBLFR[j % 4];
                        answer += "0";
                        runstep(ctempBLFR[j % 4] + "0");

                        for(int k = 0; k < cnt; k++) {
                            answer += "U0";
                            runstep("U0");
                        }
                    }

                }

                #endregion
            }

            int[] unalign_index = { 0, 0, 0, 0};                            ///没对齐面码
            
            int index = 0;
            for(int i = 0; i < 4; i++) {

                int cnt = 0;                //对齐个数
                for(int j = 0; j < 4; j++) {
                    if(Cube_copy.CubeColor[itemp1234[j], 5] == Cube_copy.CubeColor[itemp1234[j], 8]) {
                        cnt++;
                    }
                }

                if(cnt >= 2) {
                    for(int k = 0; k < 4; k++) {
                        if(Cube_copy.CubeColor[itemp1234[k], 5] != Cube_copy.CubeColor[itemp1234[k], 8]) {
                            unalign_index[index++] = k;
                        }
                    }
                    break;
                }
                else {
                    answer += "u1";
                    runstep("u1");
                }
            }

            if(index == 2) {
                int dif = unalign_index[1] - unalign_index[0];
                //相对
                if(dif == 2) {
                    if(Cube_copy.CubeColor[2, 5] != Cube_copy.CubeColor[2, 8]) {
                        answer += "y0";
                        runstep("y0");
                    }
                    answer += "R2L2D2R2L2";
                    runstep("R2");
                    runstep("L2");
                    runstep("D2");
                    runstep("R2");
                    runstep("L2");
                }
                ///相邻
                else {
                    int faceindex = 0;
                    for(int i = 1; i < 4; i++) {
                        if(Cube_copy.CubeColor[itemp1234[i], 5] == Cube_copy.CubeColor[itemp1234[i], 8] &&
                           Cube_copy.CubeColor[itemp2341[i], 5] == Cube_copy.CubeColor[itemp2341[i], 8]) {
                            faceindex = i;
                            break;
                        }
                    }
                    for(int i = 0; i <= faceindex % 4; i++) {
                        answer += "y0";
                        runstep("y0");
                    }

                    answer += "L1D1L0D0L1";
                    runstep("L1");
                    runstep("D1");
                    runstep("L0");
                    runstep("D0");
                    runstep("L1");
                }
            }

        }

        /// <summary>
        /// 还原魔方第二步：四个T字型
        /// </summary>
        public void step2_T() {
            for(int t = 0; t < 5; t++) {
                step2_T_sub2();
                #region 底层角块1
                for(int i = 0; i < 4; i++) {
                    ///角块是白色的
                    if(Cube_copy.CubeColor[itemp1234[i], 9] == uniformization[0]) {
                        answer += ctempBLFR[i];
                        answer += "1";
                        runstep(ctempBLFR[i] + "1");

                        answer += "U1";
                        runstep("U1");

                        answer += ctempBLFR[i];
                        answer += "0";
                        runstep(ctempBLFR[i] + "0");
                    }
                }

                #endregion
                step2_T_sub2();
                #region 底层角块2
                for(int i = 0; i < 4; i++) {
                    ///角块是白色的
                    if(Cube_copy.CubeColor[itemp1234[i], 7] == uniformization[0]) {
                        answer += ctempBLFR[i];
                        answer += "0";
                        runstep(ctempBLFR[i] + "0");

                        answer += "U0";
                        runstep("U0");

                        answer += ctempBLFR[i];
                        answer += "1";
                        runstep(ctempBLFR[i] + "1");
                    }
                }
                #endregion
                step2_T_sub2();
                #region 顶层角块3
                for(int i = 0; i < 4; i++) {
                    ///顶层是白色
                    if(Cube_copy.CubeColor[5, itemp7931[i]] == uniformization[0]) {
                        int j = i;
                        int cnt = 0;
                        while(Cube_copy.CubeColor[0, itemp7139[j%4]] == uniformization[0]) {
                            answer += "U1";
                            runstep("U1");
                            j++;
                            cnt++;
                        }
                        answer += ctempBLFR[j % 4];
                        answer += "1";
                        runstep(ctempBLFR[j % 4] + "1");

                        answer += "U0";
                        runstep("U0");

                        answer += ctempBLFR[j % 4];
                        answer += "0";
                        runstep(ctempBLFR[j % 4] + "0");

                        for(int k = 0; k < cnt; k++) {
                            answer += "U0";
                            runstep("U0");
                        }
                    }
                }

                #endregion
                step2_T_sub2();
            }

            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[0, itemp7139[i]] == uniformization[0] &&
                    Cube_copy.CubeColor[itemp1234[i], 9] != Cube_copy.CubeColor[itemp1234[i], 5] ) {
                    answer += ctempBLFR[i];
                    answer += "1";
                    runstep(ctempBLFR[i] + "1");

                    answer += "U1";
                    runstep("U1");

                    answer += ctempBLFR[i];
                    answer += "0";
                    runstep(ctempBLFR[i] + "0");
                }
                step2_T_sub2();
            }
        }

        /// <summary>
        /// 还原魔方第二步的子步骤：还原顶层棱块
        /// </summary>
        public void step2_T_sub2() {
            #region 顶层角块1
            for(int i = 0; i < 4; i++) {
                ///顶层角块是白色
                if(Cube_copy.CubeColor[itemp3412[i], 1] == uniformization[0]) {
                    int j = i;
                    int cnt = 0;
                    while(Cube_copy.CubeColor[5, itemp7931[j % 4]] != Cube_copy.CubeColor[itemp2341[j % 4], 5]) {
                        answer += "U1";
                        runstep("U1");
                        j++;
                        cnt++;
                    }
                    answer += ctempBLFR[j % 4];
                    answer += "1";
                    runstep(ctempBLFR[j % 4] + "1");

                    answer += "U0";
                    runstep("U0");

                    answer += ctempBLFR[j % 4];
                    answer += "0";
                    runstep(ctempBLFR[j % 4] + "0");

                    for(int k = 0; k < cnt; k++) {
                        answer += "U0";
                        runstep("U0");
                    }
                }
            }
            #endregion

            #region 顶层角块2
            for(int i = 0; i < 4; i++) {
                ///顶层角块是白色
                if(Cube_copy.CubeColor[itemp3412[i], 3] == uniformization[0]) {
                    int j = i;
                    int cnt = 0;
                    while(Cube_copy.CubeColor[5, itemp9317[j % 4]] != Cube_copy.CubeColor[itemp4123[j % 4], 5]) {
                        answer += "U1";
                        runstep("U1");
                        j++;
                        cnt++;
                    }
                    answer += ctempBLFR[j % 4];
                    answer += "0";
                    runstep(ctempBLFR[j % 4] + "0");

                    answer += "U1";
                    runstep("U1");

                    answer += ctempBLFR[j % 4];
                    answer += "1";
                    runstep(ctempBLFR[j % 4] + "1");

                    for(int k = 0; k < cnt; k++) {
                        answer += "U0";
                        runstep("U0");
                    }
                }
            }
            #endregion
        }

        /// <summary>
        /// 还原魔方第三步：第二层的四个棱块
        /// </summary>
        public void step3_second() {
            for(int t = 0; t < 4; t++) {
                step3_second_sub2();
                for(int i = 0; i < 4; i++) {
                    if(Cube_copy.CubeColor[itemp1234[i], 6] != uniformization[5] &&
                       Cube_copy.CubeColor[itemp2341[i], 4] != uniformization[5] &&
                       Cube_copy.CubeColor[itemp1234[i], 6] != Cube_copy.CubeColor[itemp1234[i], 5]) {
                        switch(i) {
                            case 0:
                                answer += "y2";
                                runstep("y2");
                                break;
                            case 1:
                                answer += "y1";
                                runstep("y1");
                                break;
                            case 3:
                                answer += "y0";
                                runstep("y0");
                                break;
                            default:
                                break;
                        }
                        answer += "U0R0U1R1U1F1U0F0";
                        runstep("U0");
                        runstep("R0");
                        runstep("U1");
                        runstep("R1");
                        runstep("U1");
                        runstep("F1");
                        runstep("U0");
                        runstep("F0");
                        step3_second_sub2();
                    }
                }
            }
        }

        /// <summary>
        /// 还原魔方第三步的子步骤：将第二层棱块恢复
        /// </summary>
        public void step3_second_sub2() {
            for(int i = 0; i < 4; i++) {
                ///不是顶层棱块
                if(Cube_copy.CubeColor[itemp1234[i], 2] != uniformization[5] &&
                   Cube_copy.CubeColor[5, itemp2486[i]] != uniformization[5]) {
                    int j = i;
                    int cnt = 0;
                    while(Cube_copy.CubeColor[itemp1234[j % 4], 2] != Cube_copy.CubeColor[itemp1234[j % 4], 5]) {
                        answer += "U1";
                        runstep("U1");
                        j++;
                        cnt++;
                    }
                    int count = (cnt + i) % 4;
                    switch(count) {
                        case 0:
                            answer += "y2";
                            runstep("y2");
                            break;
                        case 1:
                            answer += "y1";
                            runstep("y1");
                            break;
                        case 3:
                            answer += "y0";
                            runstep("y0");
                            break;
                        default:
                            break;
                    }

                    if(Cube_copy.CubeColor[5, 8] == Cube_copy.CubeColor[2, 5]) {
                        answer += "U1L1U0L0U0F0U1F1";
                        runstep("U1");
                        runstep("L1");
                        runstep("U0");
                        runstep("L0");
                        runstep("U0");
                        runstep("F0");
                        runstep("U1");
                        runstep("F1");
                    }
                    else {
                        answer += "U0R0U1R1U1F1U0F0";
                        runstep("U0");
                        runstep("R0");
                        runstep("U1");
                        runstep("R1");
                        runstep("U1");
                        runstep("F1");
                        runstep("U0");
                        runstep("F0");
                    }
                }
            }
        }

        /// <summary>
        /// 还原魔方第四步：在顶层划十字
        /// </summary>
        public void step4_new_cross() {  
            int cnt = 0;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[5, itemp2486[i]] == uniformization[5]) {
                    cnt++;
                }
            }
            if(cnt == 0) {
                step4_new_cross_sub();
                step4_new_cross_sub();
                answer += "U0";
                runstep("U0");
                step4_new_cross_sub();
            }
            else if(cnt == 2) {
                if(Cube_copy.CubeColor[5, 2] != Cube_copy.CubeColor[5, 8]) {
                    while(Cube_copy.CubeColor[5, 8] != uniformization[5] ||
                          Cube_copy.CubeColor[5, 6] != uniformization[5]) {
                        answer += "U1";
                        runstep("U1");
                    }
                    step4_new_cross_sub();
                    answer += "U0";
                    runstep("U0");
                    step4_new_cross_sub();
                }
                else {
                    if(Cube_copy.CubeColor[5, 4] != uniformization[5]) {
                        answer += "U1";
                        runstep("U1");
                    }
                    step4_new_cross_sub();
                }
            }
        }

        /// <summary>
        /// 还原魔方第四步的子步骤：划顶层十字
        /// </summary>
        public void step4_new_cross_sub() {
            answer += "F0R0U0R1U1F1";
            runstep("F0");
            runstep("R0");
            runstep("U0");
            runstep("R1");
            runstep("U1");
            runstep("F1");
        }

        /// <summary>
        /// 还原魔方第五步：调整顶层角块朝向
        /// </summary>
        public void step5_top() {
            int cnt = 0;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[5, itemp1379[i]] != uniformization[5]) {
                    cnt++;
                }
            }
            if(cnt == 2) {
                while(!(Cube_copy.CubeColor[1, 3] == uniformization[5] && 
                        Cube_copy.CubeColor[3, 1] == uniformization[5]) &&
                      !(Cube_copy.CubeColor[1, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[1, 1] == uniformization[5]) &&
                      !(Cube_copy.CubeColor[1, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[4, 1] == uniformization[5])) {
                    answer += "U1";
                    runstep("U1");
                }
                step5_top_sub2();

                while(!(Cube_copy.CubeColor[1, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[2, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[3, 3] == uniformization[5]) ) {
                    answer += "U0";
                    runstep("U0");
                }

                ///3:直接sub1
                ///4：先U2再sub1
                ///5：先U0再sub1
                step5_top_sub1();

            }
            else if(cnt == 3) {
                while(!(Cube_copy.CubeColor[1, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[2, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[3, 3] == uniformization[5]) &&
                      !(Cube_copy.CubeColor[1, 1] == uniformization[5] &&
                        Cube_copy.CubeColor[4, 1] == uniformization[5] &&
                        Cube_copy.CubeColor[3, 1] == uniformization[5])) {
                    answer += "U0";
                    runstep("U0");
                }
                if(Cube_copy.CubeColor[1, 3] != uniformization[5]) {
                    step5_top_sub2();
                }
                else {
                    step5_top_sub1();
                }
            }
            else {
                while(!(Cube_copy.CubeColor[1, 1] == uniformization[5] &&
                        Cube_copy.CubeColor[2, 1] == uniformization[5] &&
                        Cube_copy.CubeColor[2, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[3, 3] == uniformization[5]) &&
                      !(Cube_copy.CubeColor[2, 1] == uniformization[5] &&
                        Cube_copy.CubeColor[1, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[4, 3] == uniformization[5] &&
                        Cube_copy.CubeColor[4, 1] == uniformization[5])) {
                    answer += "U1";
                    runstep("U1");
                }
                step5_top_sub2();
                if(Cube_copy.CubeColor[2, 3] != uniformization[5]) {
                    answer += "U0";
                    runstep("U0");
                }
                step5_top_sub2();
                ///6:先U0再sub2
                ///7：直接sub2
            }
        }

        /// <summary>
        /// 还原魔方第五步的子步骤：还原三个角块1
        /// </summary>
        public void step5_top_sub1() {
            answer += "L0U0L1U0L0U2L1";
            runstep("L0");
            runstep("U0");
            runstep("L1");
            runstep("U0");
            runstep("L0");
            runstep("U2");
            runstep("L1");
        }

        /// <summary>
        /// 还原魔方第五步的子步骤：还原三个角块2
        /// </summary>
        public void step5_top_sub2() {
            answer += "R1U1R0U1R1U2R0";
            runstep("R1");
            runstep("U1");
            runstep("R0");
            runstep("U1");
            runstep("R1");
            runstep("U2");
            runstep("R0");
        }

        /// <summary>
        /// 还原魔方第六步：调整顶层角块顺序
        /// </summary>
        public void step6_top_2() {
            int cnt = 0;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[itemp1234[i], 1] == Cube_copy.CubeColor[itemp1234[i], 3]) {
                    cnt++;
                }
            }

            if(cnt == 0) {
                step6_top_2_sub();
                step6_top_2_sub2();
            }
            else if(cnt == 1) {
                step6_top_2_sub2();
            }

            int index = -1;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[itemp1234[i], 5] == Cube_copy.CubeColor[1, 1]) {
                    index = i + 1;
                    break;
                }
            }
            switch(index) {
                case 2:
                    answer += "U1";
                    runstep("U1");
                    break;
                case 3:
                    answer += "U2";
                    runstep("U2");
                    break;
                case 4:
                    answer += "U0";
                    runstep("U0");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 还原魔方第六步的子步骤：恢复四个顶层棱块
        /// </summary>
        public void step6_top_2_sub() {
            answer += "R0B1R0F2R1B0R0F2R2";
            runstep("R0");
            runstep("B1");
            runstep("R0");
            runstep("F2");
            runstep("R1");
            runstep("B0");
            runstep("R0");
            runstep("F2");
            runstep("R2");
        }

        /// <summary>
        /// 还原魔方第六步的子步骤：无方向限制恢复四个顶层棱块
        /// </summary>
        public void step6_top_2_sub2() {
            int index = -1;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[itemp1234[i], 1] == Cube_copy.CubeColor[itemp1234[i], 3]) {
                    index = i + 1;
                    break;
                }
            }
            switch(index) {
                case 1:
                    answer += "U2";
                    runstep("U2");
                    break;
                case 2:
                    answer += "U1";
                    runstep("U1");
                    break;
                case 4:
                    answer += "U0";
                    runstep("U0");
                    break;
                default:
                    break;
            }
            step6_top_2_sub();
        }

        /// <summary>
        /// 还原魔方第七步：调整顶层棱块顺序
        /// </summary>
        public void step7_top_3() {
            int index = -1;
            for(int i = 0; i < 4; i++) {
                if(Cube_copy.CubeColor[itemp1234[i], 1] == Cube_copy.CubeColor[itemp1234[i], 2]) {
                    index = i + 1;
                    break;
                }
            }
            if(index == -1) {
                step7_top_3_sub2();
                int iindex = -1;
                for(int i = 0; i < 4; i++) {
                    if(Cube_copy.CubeColor[itemp1234[i], 1] == Cube_copy.CubeColor[itemp1234[i], 2]) {
                        iindex = i + 1;
                        break;
                    }
                }
                switch(iindex) {
                    case 2:
                        answer += "y0";
                        runstep("y0");
                        break;
                    case 3:
                        answer += "y2";
                        runstep("y2");
                        break;
                    case 4:
                        answer += "y1";
                        runstep("y1");
                        break;
                    default:
                        break;
                }
                if(Cube_copy.CubeColor[3, 2] == Cube_copy.CubeColor[4, 5]) {
                    step7_top_3_sub2();
                }
                else {
                    step7_top_3_sub1();
                }
            }
            else {
                switch(index) {
                    case 2:
                        answer += "y0";
                        runstep("y0");
                        break;
                    case 3:
                        answer += "y2";
                        runstep("y2");
                        break;
                    case 4:
                        answer += "y1";
                        runstep("y1");
                        break;
                    default:
                        break;
                }
                if(Cube_copy.CubeColor[3, 2] == Cube_copy.CubeColor[4, 5]) {
                    step7_top_3_sub2();
                }
                else if(Cube_copy.CubeColor[3, 2] == Cube_copy.CubeColor[2, 5]) {
                    step7_top_3_sub1();
                }
            }
        }

        /// <summary>
        /// 还原魔方第七步的子步骤：调整顶层棱块顺序1
        /// </summary>
        public void step7_top_3_sub1() {
            answer += "L1U0L1U1L1U1L1U0L0U0L2";
            runstep("L1");
            runstep("U0");
            runstep("L1");
            runstep("U1");
            runstep("L1");
            runstep("U1");
            runstep("L1");
            runstep("U0");
            runstep("L0");
            runstep("U0");
            runstep("L2");
        }

        /// <summary>
        /// 还原魔方第七步的子步骤：调整顶层棱块顺序2
        /// </summary>
        public void step7_top_3_sub2() {
            answer += "R0U1R0U0R0U0R0U1R1U1R2";
            runstep("R0");
            runstep("U1");
            runstep("R0");
            runstep("U0");
            runstep("R0");
            runstep("U0");
            runstep("R0");
            runstep("U1");
            runstep("R1");
            runstep("U1");
            runstep("R2");
        }

        /// <summary>
        /// 运行一个指令，例如：R0，L2，U1
        /// </summary>
        /// <param name="solve">指令</param>
        public void runstep(String solve) {
            int i = 0;
            if(solve[i] == 'U') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.U0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.U1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.U2();
                }
            }
            else if(solve[i] == 'D') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.D0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.D1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.D2();
                }
            }
            else if(solve[i] == 'L') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.L0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.L1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.L2();
                }
            }
            else if(solve[i] == 'R') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.R0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.R1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.R2();
                }
            }
            else if(solve[i] == 'F') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.F0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.F1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.F2();
                }
            }
            else if(solve[i] == 'B') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.B0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.B1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.B2();
                }
            }
            else if(solve[i] == 'x') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.x0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.x1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.x2();
                }

            }
            else if(solve[i] == 'y') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.y0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.y1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.y2();
                }

            }
            else if(solve[i] == 'z') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.z0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.z1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.z2();
                }
            }
            else if(solve[i] == 'u') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.u0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.u1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.u2();
                }
            }
            else if(solve[i] == 'd') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.d0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.d1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.d2();
                }
            }
            else if(solve[i] == 'l') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.l0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.l1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.l2();
                }
            }
            else if(solve[i] == 'r') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.r0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.r1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.r2();
                }
            }
            else if(solve[i] == 'f') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.f0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.f1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.f2();
                }
            }
            else if(solve[i] == 'b') {
                if(solve[i + 1] == '0') {
                    Form1.Cube.b0();
                }
                else if(solve[i + 1] == '1') {
                    Form1.Cube.b1();
                }
                else if(solve[i + 1] == '2') {
                    Form1.Cube.b2();
                }
            }
        }
    }
}
