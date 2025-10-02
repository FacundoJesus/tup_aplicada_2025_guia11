using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    public interface IFiguraDAL
    {
        List<FiguraModel> GetAll();
        FiguraModel GetById(int id);
        FiguraModel Add(FiguraModel figura);
        FiguraModel Save(FiguraModel entidad);
        void Delete(int id);
    }
}
