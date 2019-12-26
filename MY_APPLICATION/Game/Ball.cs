namespace Game
{
	public class Ball : Base
	{
		public Ball
			(System.Windows.Forms.PictureBox scene, Settings settings, Board board, Racket racket)
			: base(scene, settings)
		{
			Board = board;
			Racket = racket;

			Width = settings.BallDiameter;
			Height = settings.BallDiameter;
			BackColor = settings.BallBackColor;

			//SpeedX =
			//	Infrastructure.Utility.GetRandom() * GetRandomSpeedX();

			//SpeedY =
			//	Infrastructure.Utility.GetRandom() * GetRandomSpeedY();

			SpeedX =
				Infrastructure.Utility.GetRandom() * 2;

			SpeedY =
				Infrastructure.Utility.GetRandom() * 4;

			Y = Board.Y;
			X = Infrastructure.Utility.GetRandomNumber(Board.X + Width, Board.X + board.Width - Width);

			MyTimer.Start();
		}

		protected bool Killed { get; set; }

		protected Board Board { get; set; }

		protected Racket Racket { get; set; }

		protected int SpeedX { get; set; }

		protected int SpeedY { get; set; }

		protected System.Drawing.Color BackColor { get; set; }

		private System.Drawing.Brush backColorBrush;

		protected System.Drawing.Brush BackColorBrush
		{
			get
			{
				if (backColorBrush == null)
				{
					backColorBrush =
						new System.Drawing.SolidBrush(BackColor);
				}

				return backColorBrush;
			}
		}

		private System.Drawing.Image myImage;

		protected virtual System.Drawing.Image MyImage
		{
			get
			{
				if (myImage == null)
				{
					string pathName =
						Infrastructure.Utility.GetPathName("Ball.png");

					myImage =
						System.Drawing.Image.FromFile(filename: pathName);
				}

				return myImage;
			}
		}

		private System.Timers.Timer myTimer { get; set; }

		protected System.Timers.Timer MyTimer
		{
			get
			{
				if (myTimer == null)
				{
					myTimer =
						new System.Timers.Timer(interval: 1);

					myTimer.Elapsed += MyTimer_Elapsed;
				}

				return myTimer;
			}
		}

		protected virtual int GetRandomSpeedX()
		{
			int result =
				Infrastructure.Utility.GetRandomNumber(1, 5);

			return result;
		}

		protected virtual int GetRandomSpeedY()
		{
			int result =
				Infrastructure.Utility.GetRandomNumber(1, 5);

			return result;
		}

		protected override void Scene_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			base.Scene_Paint(sender, e);

			if (Killed)
			{
				e.Graphics.FillEllipse
					(brush: System.Drawing.Brushes.Transparent, x: X, y: Y, width: Width, height: Height);

				Dispose();
			}
			else
			{
				e.Graphics.DrawImage(image: MyImage, x: X, y: Y, width: Width, height: Height);

				//e.Graphics.FillEllipse
				//	(brush: BackColorBrush, x: X, y: Y, width: Width, height: Height);
			}
		}

		private void MyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			X += SpeedX;
			Y += SpeedY;

			if (X < Board.X)
			{
				SpeedX =
					(-1) * SpeedX;

				//SpeedX =
				//	(1) * GetRandomSpeedX();
			}
			else
			{
				if (X + Width > Board.X + Board.Width)
				{
					SpeedX =
						(-1) * SpeedX;

					//SpeedX =
					//	(-1) * GetRandomSpeedX();
				}
			}

			if (Y < Board.Y)
			{
				SpeedY =
					(-1) * SpeedY;

				//SpeedY =
				//	(1) * GetRandomSpeedY();
			}
			else
			{
				if (Y + Height + SpeedY + Racket.Height >= Racket.Y)
				{
					if ((X > Racket.X) && (X < Racket.X + Racket.Width))
					{
						//Infrastructure.Utility.PlaySoundEffect_Impact();

						SpeedY =
							(-1) * SpeedY;

						//SpeedY =
						//	(-1) * GetRandomSpeedY();

						Scene.Invalidate();

						return;
					}
				}

				if (Y + Height > Board.Y + Board.Height)
				{
					//SpeedY =
					//	(-1) * SpeedY;

					Kill();
				}
			}

			Scene.Invalidate();
		}

		public virtual void Kill()
		{
			Killed = true;
		}

		public override void Dispose()
		{
			if (myTimer != null)
			{
				myTimer.Enabled = false;
				myTimer.Dispose();
				myTimer = null;
			}
		}
	}
}
