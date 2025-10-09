using GeometriaModels.DALs;
using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Services
{
    public class FiguraService
    {
        IFiguraDAL _figurasDAL;

        public FiguraService(IFiguraDAL figurasDAL)
        {
            _figurasDAL = figurasDAL;
        }

        public List<FiguraModel> GetAll()
        {
            return _figurasDAL.GetAll();
        }

        public FiguraModel GetById(int id)
        {
            return _figurasDAL.GetById(id);
        }

        public FiguraModel AddFigura(FiguraModel nueva)
        {
            return _figurasDAL.Add(nueva);
        }

    }
}
