using GeometriaModels.DALs;
using GeometriaModels.Models;
using GeometriaModels.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeometriaAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FigurasController:ControllerBase
    {
        FiguraService _figurasService;

        public FigurasController(FiguraService figurasService)
        {
            _figurasService = figurasService;
        }

        [HttpGet]
        public ActionResult<FiguraDTO> Get()
        {
            try
            {
                var figuras = _figurasService.GetAll();
                var figurasDTO = (from f in figuras select ConvertToFiguraDTO(f)).ToList();
                return Ok(figurasDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<FiguraDTO> Get(int? id)
        {
            try
            {
                if (id == null || id <= 0) return BadRequest("id es requerido");

                var figura = _figurasService.GetById(id ?? 0);

                if (figura == null) return NotFound();

                return Ok(ConvertToFiguraDTO(figura));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<FiguraDTO> Post([FromBody] FiguraDTO? figura = null)
        {
            if (figura == null) return BadRequest("objeto figura es requerido");

            FiguraModel figuraModel = null;

            if (figura.Tipo == 1)
            {
                figuraModel = new RectanguloModel
                {
                    Id = figura.Id,
                    Area = figura.Area,
                    Ancho = figura.Ancho,
                    Largo = figura.Largo
                };
            }
            else if (figura.Tipo == 2)
            {
                figuraModel = new CirculoModel
                {
                    Id = figura.Id,
                    Area = figura.Area,
                    Radio = figura.Radio
                };
            }

            _figurasService.AddFigura(figuraModel);


            return Ok(ConvertToFiguraDTO(figuraModel));
        }

        private FiguraDTO ConvertToFiguraDTO(FiguraModel figuraModel)
        {
            var figuraDTO = new FiguraDTO
            {
                Id = figuraModel.Id,
                Area = figuraModel.Area,
                Tipo = (figuraModel is RectanguloModel) ? 1 : 2,
                Ancho = (figuraModel is RectanguloModel rectangulo) ? rectangulo.Ancho : null,
                Largo = (figuraModel is RectanguloModel rectangulo2) ? rectangulo2.Largo : null,
                Radio = (figuraModel is CirculoModel circulo) ? circulo.Radio : null
            };
            return figuraDTO;
        }
    }

}
}
