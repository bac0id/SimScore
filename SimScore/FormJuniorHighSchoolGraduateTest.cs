using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace SimScore
{
	/// <summary>
	/// 上海市初中毕业统一学业考试成绩查询模拟器
	/// </summary>
	public partial class FormJuniorHighSchoolGraduateTest : Form
	{
		private  Random r = new Random();

		private  DateTime openTime = DateTime.Now;
		public FormJuniorHighSchoolGraduateTest()
		{
			InitializeComponent();
			pictureBox1.Image = GetVerifyImg();
			this.Text = this.openTime.Year + this.Text;
			lblTitle.Text = this.openTime.Year + lblTitle.Text;
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
				label29.Text = txb1.Text;
				label9.Text = txb1.Text;
				label24.Text = $"{this.openTime.Year}年{this.openTime.Month}月";
				ReverseVisibility();
				GetAllScore();
			}
		}

		private Image GetVerifyImg()
		{
			return new Bitmap(WebRequest.Create("http://cx.shmeea.edu.cn/shmeea/q/verifyImg")
				.GetResponse()
				.GetResponseStream());
		}

		private void GetAllScore()
		{
			label23.Text = r.Next(151).ToString();
			label22.Text = r.Next(151).ToString();
			label21.Text = r.Next(151).ToString();
			label20.Text = r.Next(91).ToString();
			label19.Text = r.Next(61).ToString();
			label18.Text = r.Next(31).ToString();
		}
		private void Btn2_Click(object sender, EventArgs e)
		{
			ReverseVisibility();
		}
		private void ReverseVisibility() {

			//显示首页
			label1.Visible = !label1.Visible;
			txb1.Visible = !txb1.Visible;
			label5.Visible = !label5.Visible;

			label2.Visible = !label2.Visible;
			txb2.Visible = !txb2.Visible;
			label6.Visible = !label6.Visible;

			label26.Visible = !label26.Visible;
			txb4.Visible = !txb4.Visible;
			label17.Visible = !label17.Visible;

			label3.Visible = !label3.Visible;
			txb3.Visible = !txb3.Visible;
			pictureBox1.Visible = !pictureBox1.Visible;
			label7.Visible = !label7.Visible;

			btn1.Visible = !btn1.Visible;

			label4.Visible = !label4.Visible;

			//清除成绩
			label28.Visible =! label28.Visible;
			label29.Visible =! label29.Visible;
			label8.Visible = ! label8.Visible ;
			label9.Visible = ! label9.Visible ;
			label25.Visible =! label25.Visible;
			label24.Visible =! label24.Visible;

			label12.Visible = !label12.Visible;
			label13.Visible = !label13.Visible;
			label14.Visible = !label14.Visible;
			label15.Visible = !label15.Visible;
			label16.Visible = !label16.Visible;
			label27.Visible = !label27.Visible;
							  
			label23.Visible = !label23.Visible;
			label22.Visible = !label22.Visible;
			label21.Visible = !label21.Visible;
			label20.Visible = !label20.Visible;
			label19.Visible = !label19.Visible;
			label18.Visible = !label18.Visible;

			btn2.Visible = !btn2.Visible;

			label10.Visible = !label10.Visible;
			label11.Visible = !label11.Visible;
			pictureBox3.Visible = !pictureBox3.Visible;
		}
	}
}
