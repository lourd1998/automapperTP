using AutomapperTp.Models;

namespace AutomapperTp.Repositories
{
    public class ArticuloRepository: IarticuloRepository
    {
        public ArticuloDto GetArticulo()
        {
            return new ArticuloDto
            {
                Id = 1,
                NameArt = "Tv",
                Categoria = "Electrodomestico",
                Cantidad = 4
            };
        }
    }
}
