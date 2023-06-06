using System;
using AutoMapper;
using App.Core.Services;
using App.Core.Models;
using App.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using App.Api.Filter;

namespace App.API.Controllers
{
	public class BagController:BaseCustomController
	{
		private readonly IMapper _mapper;
		private readonly IGenericService<Bag> _service;



		public BagController(IMapper mapper, IGenericService<Bag> service )
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var all = await _service.GetAllAsync();
			var m_all = _mapper.Map<List<BagDto>>(all.ToList());
            return CreateActionResult(CustomResponseDto<List<BagDto>>.Success(200,m_all));
		}

		[HttpPost]
		public async Task<IActionResult> Add(BagDto BagDto)
		{
			var Bag = await _service.AddAsync(_mapper.Map<Bag>(BagDto));
			return CreateActionResult(CustomResponseDto<BagDto>.Success(200,_mapper.Map<BagDto>(Bag)));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddRange(List<BagDto> BagDtos)
		{
			var Bags = await _service.AddRangeAsync(_mapper.Map<List<Bag>>(BagDtos));
            return CreateActionResult(CustomResponseDto<List<BagDto>>.Success(200,_mapper.Map<List<BagDto>>(Bags)));
        }

        [ServiceFilter(typeof(NotFoundFilter<Bag>))]
        [HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var Bag = await _service.GetByIdAsync(id);
			return CreateActionResult(CustomResponseDto<BagDto>.Success(200,_mapper.Map<BagDto>(Bag)));
		}

        [ServiceFilter(typeof(NotFoundFilter<Bag>))]
        [HttpPut]
		public async Task<IActionResult> Update(Guid id)
		{
			var entity = await _service.GetByIdAsync(id);
			await _service.Update(entity);
			return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
		}

        [ServiceFilter(typeof(NotFoundFilter<Bag>))]
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(entity);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }



    }
}

