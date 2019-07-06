using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
namespace SimScore
{
    /// <summary>
    /// 上海市普通高中学业水平等级性考试成绩查询模拟器
    /// </summary>
    public partial class FormSeniorHighSchoolAdd3Test : Form
    {
        static Random r = new Random((int)DateTime.Now.ToFileTimeUtc());
        static bool isDili, isLishi, isWuli, isHuaxue, isShengke, isZhengzhi;
        static byte subject = 0;
        static string year = DateTime.Now.Year.ToString();
        static int month = DateTime.Now.Month;
        public FormSeniorHighSchoolAdd3Test()
        {
            InitializeComponent();
            pictureBox1.Image = GetVerifyImg();
            this.Text = year + this.Text;
            lblTitle.Text = year + lblTitle.Text;
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GetVerifyImg();
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb1.Text) || string.IsNullOrEmpty(txb2.Text) || string.IsNullOrEmpty(txb3.Text))
            {
                MessageBox.Show("请填写完整！");
            }
            else
            {
                if (subject < 1 || subject > 3)
                {
                    MessageBox.Show("报考学科填写有误！");
                }
                else
                {
                    label29.Text = txb1.Text;
                    label9.Text = txb1.Text;
                    label24.Text = year + "年" + (month - 1).ToString() + "月";

                    //清空首页
                    label1.Visible = false;
                    txb1.Visible = false;
                    label5.Visible = false;

                    label2.Visible = false;
                    txb2.Visible = false;
                    label6.Visible = false;

                    label26.Visible = false;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    checkBox5.Visible = false;
                    checkBox6.Visible = false;
                    label27.Visible = false;

                    label3.Visible = false;
                    txb3.Visible = false;
                    pictureBox1.Visible = false;
                    label7.Visible = false;
                    
                    btn1.Visible = false;

                    label4.Visible = false;

                    //显示成绩
                    label28.Visible = true;
                    label29.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label25.Visible = true;
                    label24.Visible = true;

                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;

                    label23.Visible = true;
                    label22.Visible = true;
                    label21.Visible = true;
                    label20.Visible = true;
                    label19.Visible = true;
                    label18.Visible = true;

                    btn2.Visible = true;

                    label10.Visible = true;
                    label11.Visible = true;
                    pictureBox3.Visible = true;

                    GetScore(); 
                }
            }
        }
        private Image GetVerifyImg()
        {
            return new Bitmap(WebRequest.Create("http://cx.shmeea.edu.cn/shmeea/q/verifyImg")
                .GetResponse()
                .GetResponseStream());
        }
        private string GetOneScore()
        {
            switch (r.Next(0, 12))
            {
                case 0: return "E";
                case 1: return "D";
                case 2: return "D+";
                case 3: return "C-";
                case 4: return "C";
                case 5: return "C+";
                case 6: return "B-";
                case 7: return "B";
                case 8: return "B+";
                case 9: return "A";
                case 10: return "A+";
                default: return "";
            }
        }
        private void SetSubject(ref bool isChosen, CheckBox checkBox)
        {
            isChosen = checkBox.Checked;
            if (isChosen) subject++;
            else subject--;
        }
        private void GetScore()
        {
            if (isDili) label23.Text = GetOneScore();
            if (isLishi) label22.Text = GetOneScore();
            if (isWuli) label21.Text = GetOneScore();
            if (isHuaxue) label20.Text = GetOneScore();
            if (isShengke) label19.Text = GetOneScore();
            if (isZhengzhi) label18.Text = GetOneScore();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isDili, checkBox1);
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            //显示首页
            label1.Visible = true;
            txb1.Visible = true;
            label5.Visible = true;

            label2.Visible = true;
            txb2.Visible = true;
            label6.Visible = true;

            label26.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            label27.Visible = true;

            label3.Visible = true;
            txb3.Visible = true;
            pictureBox1.Visible = true;
            label7.Visible = true;

            btn1.Visible = true;

            label4.Visible = true;

            //清楚成绩
            label28.Visible = false;
            label29.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label25.Visible = false;
            label24.Visible = false;

            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;

            label23.Visible = false;
            label22.Visible = false;
            label21.Visible = false;
            label20.Visible = false;
            label19.Visible = false;
            label18.Visible = false;

            btn2.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            pictureBox3.Visible = false;
        }
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isLishi, checkBox2);
        }
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isWuli, checkBox3);
        }
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isHuaxue, checkBox4);
        }
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isShengke, checkBox5);
        }
        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            SetSubject(ref isZhengzhi, checkBox6);
        }
    }
}