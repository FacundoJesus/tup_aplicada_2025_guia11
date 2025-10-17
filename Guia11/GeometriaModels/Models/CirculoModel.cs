using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace GeometriaModels.Models
{
    public class CirculoModel:FiguraModel
    {

        public double? Radio {  get; set; }

        public CirculoModel() { }
        public CirculoModel(int id, double area, double radio) : base(id, area)
        {
            this.Radio = radio;
        }

        public override double? CalcularArea()
        {
            if (Radio == null) 
                this.Area = null;
            else 
                this.Area = Radio.Value * Radio.Value * PI;
            return this.Area;

        }
    }
}
