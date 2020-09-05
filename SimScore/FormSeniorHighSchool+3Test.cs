using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace SimScore
{
	/// <summary>
	/// 上海市普通高中学业水平等级性考试成绩查询模拟器
	/// </summary>
	public partial class FormSeniorHighSchoolAdd3Test : Form
	{
		static Random r = new Random();

		static bool isDili, isLishi, isWuli, isHuaxue, isShengke, isZhengzhi;
		static byte subject = 0;

		private DateTime openTime = DateTime.Now;

		public FormSeniorHighSchoolAdd3Test()
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
				if (subject < 1 || subject > 3)
				{
					MessageBox.Show("报考学科填写有误！");
				}
				else
				{
					label29.Text = txb1.Text;
					label9.Text = txb1.Text;
					label24.Text = $"{this.openTime.Year}年{this.openTime.Month}月";

					ReversiVisibility();

					GetRatings(); 
				}
			}
		}
		private Image GetVerifyImg()
		{
			return new Bitmap(WebRequest.Create("http://cx.shmeea.edu.cn/shmeea/q/verifyImg")
				.GetResponse()
				.GetResponseStream());
		}
		private string GetRating()
		{
			switch (r.Next(11))
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
		private void GetRatings()
		{
			if (isDili) label23.Text = GetRating();
			if (isLishi) label22.Text = GetRating();
			if (isWuli) label21.Text = GetRating();
			if (isHuaxue) label20.Text = GetRating();
			if (isShengke) label19.Text = GetRating();
			if (isZhengzhi) label18.Text = GetRating();
		}
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			SetSubject(ref isDili, checkBox1);
		}
		private void Btn2_Click(object sender, EventArgs e)
		{
			ReversiVisibility();
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
		private void ReversiVisibility() {
			//首页
			label1.Visible	=!label1.Visible;
			txb1.Visible	=!txb1.Visible	;
			label5.Visible	=!label5.Visible;

			label2.Visible	=!label2.Visible;
			txb2.Visible	=!txb2.Visible	;
			label6.Visible	=! label6.Visible;

			label26.Visible		= !label26.Visible;
			checkBox1.Visible	= !checkBox1.Visible	;
			checkBox2.Visible	= !checkBox2.Visible	;
			checkBox3.Visible	= !checkBox3.Visible	;
			checkBox4.Visible	= !checkBox4.Visible	;
			checkBox5.Visible	= !checkBox5.Visible	;
			checkBox6.Visible	= !checkBox6.Visible	;
			label27.Visible		= !label27.Visible		;

			label3.Visible			= !label3.Visible;
			txb3.Visible			= !txb3.Visible		;
			pictureBox1.Visible		= !pictureBox1.Visible	;
			label7.Visible			= !label7.Visible		;

			btn1.Visible =! btn1.Visible ;

			label4.Visible = !label4.Visible;

			//显示成绩
			label28.Visible =!label28.Visible ;
			label29.Visible =!label29.Visible ;
			label8.Visible  =!label8.Visible  ;
			label9.Visible  =!label9.Visible  ;
			label25.Visible =!label25.Visible ;
			label24.Visible =!label24.Visible ;

			label12.Visible = !label12.Visible;
			label13.Visible =!label13.Visible 		;
			label14.Visible =!label14.Visible 		;
			label15.Visible =!label15.Visible 		;
			label16.Visible =!label16.Visible 		;
			label17.Visible =!label17.Visible		;

			label23.Visible = !label23.Visible;
			label22.Visible =!label22.Visible 		 ;
			label21.Visible =!label21.Visible 		 ;
			label20.Visible =!label20.Visible 		 ;
			label19.Visible =!label19.Visible 		 ;
			label18.Visible =! label18.Visible		 ;

			btn2.Visible = !btn2.Visible;

			label10.Visible			=	!label10.Visible		;
			label11.Visible			 =!	label11.Visible		;
			pictureBox3.Visible		 = !pictureBox3.Visible;
		}
	}
}
