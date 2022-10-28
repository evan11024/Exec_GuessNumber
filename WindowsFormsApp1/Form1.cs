using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private GuessNumber game;
		public Form1()
		{
			InitializeComponent();
			game = new GuessNumber();
			resultLabel.Text = String.Empty;
			game.NewGame();
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			game.NewGame();
			resultLabel.Text = game.Hint;
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			int? guessNumber = GetGuessNumber();
			if (guessNumber.HasValue == false)
			{
				MessageBox.Show("請輸入數字");
				return;
			}

			GuessResult result = game.Guess(guessNumber.Value);

			if (result.IsSuccess == true)
			{
				MessageBox.Show("您答對了");
			}
			else
			{
				MessageBox.Show("您答錯了");
				resultLabel.Text = result.Hint;
			}
		}
		private int? GetGuessNumber()
		{
			TextBox txt = this.guessTextBox;
			string input = txt.Text;
			if (string.IsNullOrEmpty(input)) return null;
			bool isInt = int.TryParse(input, out int number);
			return isInt ? number : (int?)null;
		}
	}

	public class GuessNumber
	{
		private int answer { get; set; }
		private int min = 1 , max = 99 ;
		/// <summary>
		/// 新遊戲，產生一個亂數
		/// </summary>
		public void NewGame() 
		{ 
		int seed = Guid.NewGuid().GetHashCode();
			var random = new Random(seed);
			answer = random.Next(1,100);
			min = 1;
			max = 99;
		}

		public string Hint
		{
			get
			{
				return $"{min}~{max} anser = {answer}";
			}
		}
		public GuessResult Guess(int guessNumber)
		{
			if (this.answer == guessNumber)
			{
				return GuessResult.Success();
			}
			if (guessNumber < min || guessNumber > max)
			{
				return GuessResult.Failed(this.Hint);
			}
			
			if (guessNumber > this.answer)
				{
					max = guessNumber;
				}
			else  
				{
					min = guessNumber;
				}
			return GuessResult.Failed(this.Hint);
		
		}
		}
	}
	public class GuessResult
	{
		public static GuessResult Success()
	{
		return new GuessResult { IsSuccess = true, Hint = String.Empty };
	}
		public static GuessResult Failed(string errMessage)
	{
		return new GuessResult { IsSuccess = false, Hint = errMessage };
	}

	   public bool IsSuccess { get; set; }
	   public bool IsFailed 
		{
			get { return !IsSuccess; } 
		}

		public string Hint { get; set; }
		
	}

