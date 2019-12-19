namespace Game
{
	public class Racket : Base
	{
		public Racket
			(System.Windows.Forms.PictureBox scene, Settings settings, Board board)
			: base(scene, settings)
		{
			Board = board;

			Speed = settings.RacketSpeed;
			Width = settings.RacketWidth;
			Height = settings.RacketHeight;
			BackColor = settings.RacketBackColor;
			InitialDistance = settings.RacketInitialDistance;

			X = (SceneWidth - Width) / 2;
			Y = Board.Y + Board.Height - Height - InitialDistance;

			settings.Form.KeyUp += Form_KeyUp;
			settings.Form.KeyDown += Form_KeyDown;
		}

		protected int Speed { get; set; }

		protected Board Board { get; set; }

		public bool IsUpArrowDown { get; set; }

		public bool IsDownArrowDown { get; set; }

		public bool IsLeftArrowDown { get; set; }

		public bool IsRightArrowDown { get; set; }

		protected int InitialDistance { get; set; }

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

		protected override void Scene_Paint
			(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			base.Scene_Paint(sender, e);

			e.Graphics.FillRectangle
				(brush: BackColorBrush, x: X, y: Y, width: Width, Height);
		}

		private void Form_KeyUp
			(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.Left:
				{
					IsLeftArrowDown = false;

					break;
				}

				case System.Windows.Forms.Keys.Right:
				{
					IsRightArrowDown = false;

					break;
				}

				case System.Windows.Forms.Keys.Up:
				{
					IsUpArrowDown = false;

					break;
				}

				case System.Windows.Forms.Keys.Down:
				{
					IsDownArrowDown = false;

					break;
				}
			}
		}

		private void Form_KeyDown
			(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.Left:
				{
					IsLeftArrowDown = true;

					MoveLeft();

					if (IsUpArrowDown)
					{
						MoveUp();
					}

					if (IsDownArrowDown)
					{
						MoveDown();
					}

					break;
				}

				case System.Windows.Forms.Keys.Right:
				{
					IsRightArrowDown = true;

					MoveRight();

					if (IsUpArrowDown)
					{
						MoveUp();
					}

					if (IsDownArrowDown)
					{
						MoveDown();
					}

					break;
				}

				case System.Windows.Forms.Keys.Up:
				{
					IsUpArrowDown = true;

					MoveUp();

					if (IsLeftArrowDown)
					{
						MoveLeft();
					}

					if (IsRightArrowDown)
					{
						MoveRight();
					}

					break;
				}

				case System.Windows.Forms.Keys.Down:
				{
					IsDownArrowDown = true;

					MoveDown();

					if (IsLeftArrowDown)
					{
						MoveLeft();
					}

					if (IsRightArrowDown)
					{
						MoveRight();
					}

					break;
				}
			}
		}

		protected virtual void MoveLeft()
		{
			if (X > Board.X)
			{
				X -= Speed;
			}
			else
			{
				X = Board.X;
			}

			Scene.Invalidate();
		}

		protected virtual void MoveRight()
		{
			if (X + Width < Board.X + Board.Width)
			{
				X += Speed;
			}
			else
			{
				X = Board.X + Board.Width - Width;
			}

			Scene.Invalidate();
		}

		protected virtual void MoveUp()
		{
			if (Y > Board.Y + (Board.Height / 2))
			{
				Y -= Speed;
			}
			else
			{
				Y = Board.Y + (Board.Height / 2);
			}

			Scene.Invalidate();
		}

		protected virtual void MoveDown()
		{
			if (Y + Height < Board.Y + Board.Height)
			{
				Y += Speed;
			}
			else
			{
				Y = Board.Y + Board.Height - Height;
			}

			Scene.Invalidate();
		}

		public override void Dispose()
		{
		}
	}
}
