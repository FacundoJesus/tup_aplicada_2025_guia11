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
            lvwFiguras.View = View.Tile;
            lvwFiguras.FullRowSelect = true;
            lvwFiguras.HideSelection = false;
            lvwFiguras.OwnerDraw = true;
            lvwFiguras.TileSize = new Size(300, 100);
            lvwFiguras.BackColor = Color.WhiteSmoke;
            lvwFiguras.BorderStyle = BorderStyle.None;
            lvwFiguras.DrawItem += lvwFiguras_DrawItem;
            lvwFiguras.SelectedIndexChanged += lvwFiguras_SelectedIndexChanged;
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
            lvwFiguras.Invalidate();
        }
        #endregion

        FiguraService _figurasService;

        public Form1(FiguraService figurasService)
        {
            _figurasService = figurasService;
            InitializeComponent();
            lvwInicializar();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            FiguraModel figura = null;
            if (rbRectangulo.Checked)
            {
                figura = new RectanguloModel()
                {
                    Ancho = Convert.ToDouble(tbAncho.Text),
                    Largo = Convert.ToDouble(tbLargo.Text)
                };
            }
            else if (rbCirculo.Checked)
            {
                figura = new CirculoModel()
                {
                    Radio = Convert.ToDouble(tbRadio.Text)
                };
            }

            if (figura != null)
                _figurasService.AddFigura(figura);

            btnActualizar.PerformClick();
            btnLimpiar.PerformClick();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lvwFiguras.Items.Clear();

            foreach (var figura in _figurasService.GetAll())
            {
                var item = new ListViewItem();
                if (figura is RectanguloModel r)
                {
                    item = new ListViewItem(new string[]
                    {
                    $"Rectangulo: #{r.Id}",
                    $"Area: {r.Area:f2}",
                    $"Ancho: {r.Ancho:f2}, Largo: {r.Largo:f2}"
                    });
                }
                else if (figura is CirculoModel c)
                {
                    item = new ListViewItem(new string[]
                    {
                    $"Circulo: #{c.Id}",
                    $"Area: {c.Area:f2}",
                    $"Radio: {c.Radio:f2}"
                    });
                }

                item.Tag = figura; //lo necesitamos para tomarlo luego cuando lo seleccionemos
                lvwFiguras.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbAncho.Clear();
            tbLargo.Clear();
            tbRadio.Clear();
            tbArea.Clear();

            tbAncho.Enabled = true;
            tbLargo.Enabled = true;
            tbRadio.Enabled = true;
            tbArea.Enabled = true;

            lvwFiguras.SelectedItems.Clear();
            rbRectangulo.Checked = false;
            rbCirculo.Checked = false;
            rbRectangulo.Enabled = true;
            rbCirculo.Enabled = true;
        }

        private void lvwFiguras_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var figuraSelected = e.Item.Tag as FiguraModel;

                if (figuraSelected != null)
                {
                    tbAncho.Clear();
                    tbLargo.Clear();
                    tbRadio.Clear();
                    rbRectangulo.Enabled = false;
                    rbCirculo.Enabled = false;

                    figuraSelected.CalcularArea(); // Esto asigna Area
                    tbArea.Text = $"{figuraSelected.Area:f2}";

                    if (figuraSelected is RectanguloModel r)
                    {
                        rbRectangulo.Checked = true;
                        tbAncho.Text = $"{r.Ancho:f2}";
                        tbLargo.Text = $"{r.Largo:f2}";
                        
                        tbAncho.Enabled = true;
                        tbLargo.Enabled = true;
                        tbRadio.Enabled = false;
                    }
                    else if (figuraSelected is CirculoModel c)
                    {
                        rbCirculo.Checked = true;
                        tbRadio.Text = $"{c.Radio:f2}";
                        
                        tbAncho.Enabled = false;
                        tbLargo.Enabled = false;
                        tbRadio.Enabled = true;
                    }
                }
            }
        }
    }
}
