using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models
{
    public abstract class FiguraModel:IComparable
    {
        public int? Id { get; set; }
        public double? Area { get; set; }

        public FiguraModel() { }

        public FiguraModel(int? id, double? area) {
            this.Id = id;
            this.Area = area;
        }

        public int CompareTo(object? obj)
        {
            FiguraModel nuevaFigura = obj as FiguraModel;
            if(nuevaFigura != null)
            {
                return this.Id.Value.CompareTo(nuevaFigura.Id);
            }
            return -1;
        }
    }
}
