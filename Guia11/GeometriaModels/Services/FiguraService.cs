using GeometriaModels.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Services
{
    public class FiguraService
    {
        IFiguraDAL FiguraDAL;

        //DOS TIPOS DE INYECCIONES DE DEPENDENCIA: por constructor o por getter y setter
        public FiguraService(IFiguraDAL f)
        {
            this.FiguraDAL = f;
        }

        //CREAR CIRCULO

        //CREAR RECTANGULO

    }
}
