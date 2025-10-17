using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models
{
    public class RectanguloModel:FiguraModel
    {
        public double? Ancho {  get; set; }
        public double? Largo { get; set; }

        public RectanguloModel() { }
        public RectanguloModel(int id,double area, double ancho, double largo) : base(id, area)
        {
            this.Ancho = ancho;
            this.Largo = largo;
        }


        public override double? CalcularArea()
        {
            // Si alguno de los valores es null, Area será null
            if (Ancho == null || Largo == null)
                this.Area = null;
            else
                this.Area = Ancho * Largo;

            return this.Area;
        }
    }
}
