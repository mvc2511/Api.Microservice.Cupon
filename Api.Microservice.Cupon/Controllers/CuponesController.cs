using Api.Microservice.Cupon.Data;
using Api.Microservice.Cupon.Models.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Microservice.Cupon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuponesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly ResponseDto _response;
        private readonly IMapper _mapper;

        public CuponesController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                IEnumerable<Api.Microservice.Cupon.Models.Cupon>
                    cupones = await _appDbContext.Cupons.ToListAsync();

                _response.Result = _mapper.Map<IEnumerable<CuponDto>>(cupones);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("id:int")]
        public async Task<ResponseDto> Get(int id)
        {
            try
            {
                Api.Microservice.Cupon.Models.Cupon
                    cupon = await _appDbContext.Cupons.FindAsync(id);

                _response.Result = _mapper.Map<CuponDto>(cupon);

                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return null;
        }


        [HttpGet]
        [Route("getbycode/{code}")]
        public async Task<ResponseDto> GetByCode(string code)
        {
            try
            {
                Api.Microservice.Cupon.Models.Cupon
                    cupon = await _appDbContext.Cupons.
                    SingleOrDefaultAsync(p => p.CuponCode.Equals(code));
                _response.Result = _mapper.Map<CuponDto>(cupon);
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return null;
        }


        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] CuponDto cuponDto)
        {
            try
            {
                Cupon.Models.Cupon obj = _mapper.Map<Cupon.Models.Cupon>(cuponDto);
                _appDbContext.Cupons.Add(obj);
                await _appDbContext.SaveChangesAsync();
                _response.Result = _mapper.Map<CuponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] CuponDto cuponDto)
        {
            try
            {
                Cupon.Models.Cupon obj = _mapper.Map<Cupon.Models.Cupon>(cuponDto);
                _appDbContext.Cupons.Update(obj);
                await _appDbContext.SaveChangesAsync();
                _response.Result = _mapper.Map<CuponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        
    }
}
