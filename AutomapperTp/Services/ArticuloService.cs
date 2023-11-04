using AutoMapper;
using AutomapperTp.Models;
using AutomapperTp.Repositories;

namespace AutomapperTp.Services
{
    public class ArticuloService: IarticuloService
    {
        private readonly IarticuloRepository _repository;
        private readonly IMapper _mapper;
        public ArticuloService(IarticuloRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public ArticuloViewModel GetArticulo()
        {
            var articulo = _repository.GetArticulo();

            return _mapper.Map<ArticuloViewModel>(articulo);

        }
    }
}
