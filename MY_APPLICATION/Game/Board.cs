namespace Game
{
	public class Board : Base
	{
		public Board(System.Windows.Forms.PictureBox scene, Settings settings) : base(scene, settings)
		{
			Width = settings.BoardWidth;
			Height = settings.BoardHeight;
			BackColor = settings.BoardBackColor;
			BorderColor = settings.BoardBorderColor;
			BorderThickness = settings.BoardBorderThickness;

			X = (SceneWidth - Width) / 2;
			Y = (SceneHeight - Height) / 2;
		}

		public override void Dispose()
		{
		}

		protected int BorderThickness { get; set; }

		protected System.Drawing.Color BackColor { get; set; }

		protected System.Drawing.Color BorderColor { get; set; }

		private System.Drawing.Pen borderPen;

		protected virtual System.Drawing.Pen BorderPen
		{
			get
			{
				if (borderPen == null)
				{
					borderPen =
						new System.Drawing.Pen(BorderColor, BorderThickness);
				}

				return borderPen;
			}
		}

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

			// **************************************************
			if (BorderThickness > 0)
			{
				for (int index = 1; index <= BorderThickness; index++)
				{
					int width = Width + 2 * index - 1;
					int height = Height + 2 * index - 1;
					int x = (SceneWidth - Width - 2 * index) / 2;
					int y = (SceneHeight - Height - 2 * index) / 2;

					e.Graphics.DrawRectangle
						(pen: BorderPen, x: x, y: y, width: width, height);
				}
			}
			// **************************************************

			// **************************************************
			e.Graphics.FillRectangle
				(brush: BackColorBrush, x: X, y: Y, width: Width, Height);
			// **************************************************
		}
	}
}
