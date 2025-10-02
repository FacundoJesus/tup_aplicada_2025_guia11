using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    public class FiguraDAL:IFiguraDAL
    {
        List<FiguraModel> figuras = new List<FiguraModel>();

        public List<FiguraModel> GetAll()
        {
            return figuras;
        }

        public FiguraModel GetById(int id)
        {
            //return (from f in figuras where f.Id == id select f).FirstOrDefault();
            return figuras.Where(p=>p.Id==id).FirstOrDefault();
            FiguraModel figura;
            figura = new CirculoModel();
            figuras.Sort();
            int idx = figuras.BinarySearch(figura);
            if(idx > -1)
            {
                figura = figuras[idx];
            }
            return figura;
        }

        public FiguraModel Add(FiguraModel f)
        {
            //figura.Id = (from f in figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
            var figura = GetById(f.Id);
            if (figura == null)
            {
                figuras.Add(figura);
            }
            return figura;
        }

        public void Delete(int id)
        {
            FiguraModel figura = GetById(id);
            if (figura != null)
            {
                figuras.Remove(figura);
            }
        }

        public FiguraModel Save(FiguraModel entidad)
        {
            var figura = GetById(entidad.Id);

            if (figuras == null)
            {
                return null;
            }
            if (figura.GetType() != entidad.GetType()) {
                return null;
            }
            if (entidad is RectanguloModel r)
            {
                var rect = figura as RectanguloModel;

                rect.Area = r.Area;
                rect.Ancho = r.Ancho;
                rect.Largo = r.Largo;
            }
            else if (entidad is CirculoModel c)
            {
                var circ = figura as CirculoModel;
                
                circ.Area = c.Area;
                circ.Radio = c.Radio;
            }
            return figura;             
        }
    }
}
