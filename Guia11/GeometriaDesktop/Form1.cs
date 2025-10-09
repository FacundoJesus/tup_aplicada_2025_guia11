using GeometriaModels.Models;
using GeometriaModels.Services;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GeometriaDesktop
{
    public partial class Form1 : Form
    {
        #region ListView redibujado
        public void lvwInicializar()
        {
            lsvFiguras.View = View.Tile;
            lsvFiguras.FullRowSelect = true;
            lsvFiguras.HideSelection = false;
            lsvFiguras.OwnerDraw = true;
            lsvFiguras.TileSize = new Size(300, 100);
            lsvFiguras.BackColor = Color.WhiteSmoke;
            lsvFiguras.BorderStyle = BorderStyle.None;
            lsvFiguras.DrawItem += lvwFiguras_DrawItem;
            lsvFiguras.SelectedIndexChanged += lvwFiguras_SelectedIndexChanged;

        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        private void lvwFiguras_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            var rect = e.Bounds;

            Color backColor = e.Item.Selected ? Color.LightBlue : Color.White;
            Color borderColor = e.Item.Selected ? Color.DodgerBlue : Color.LightGray;

            using (var brush = new SolidBrush(backColor))
            using (var pen = new Pen(borderColor, 2))
            {
                int radius = 10;
                var path = RoundedRect(rect, radius);
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            string text = e.Item.Text;
            var fontTitle = new Font("Segoe UI", 10, FontStyle.Bold);
            var fontSub = new Font("Segoe UI", 9, FontStyle.Regular);

            e.Graphics.DrawString(text, fontTitle, Brushes.Black, rect.X + 10, rect.Y + 10);

            int offsetY = 30;
            foreach (ListViewItem.ListViewSubItem sub in e.Item.SubItems)
            {
                if (sub == e.Item.SubItems[0]) continue;
                e.Graphics.DrawString(sub.Text, fontSub, Brushes.DimGray, rect.X + 10, rect.Y + offsetY);
                offsetY += 18;
            }
        }
        private void lvwFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvFiguras.Invalidate();
        }
        #endregion

        FiguraService _figurasService;

        public Form1(FiguraService figurasService)
        {
            _figurasService = figurasService;
            InitializeComponent();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            _figurasService.AddFigura(new RectanguloModel { Ancho = 2, Largo = 4 });
        }

        /*private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            foreach (var figura in _figurasService.GetAll())
            {
                lsvFiguras.Items.Add(figura);
            }
        }*/
    }
}
