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

        public FiguraModel Add(FiguraModel figura)
        {
            figura.Id = GenId();
            figuras.Add(figura);
            return figura;
        }

        public void Delete(int id)
        {
            var figura = GetById(id);
            if (figura != null)
            {
                figuras.Remove(figura);
            }
        }

        public List<FiguraModel> GetAll()
        {
            return figuras;
        }

        public FiguraModel? GetById(int id)
        {
            return (from f in figuras where f.Id == id select f).FirstOrDefault();
        }

        public FiguraModel? Save(FiguraModel entidad)
        {
            entidad.Id = GenId();
            figuras.Add(entidad);
            return entidad;
        }

        protected int? GenId()
        {
            return (from f in figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
        }
    }
}
