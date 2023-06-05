using System;
using AutoMapper;
using App.Core.Services;
using App.Core.Models;
using App.Core.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
	public class DeliveryPointController:BaseCustomController
	{
		private readonly IMapper _mapper;
		private readonly IGenericService<DeliveryPoint> _service;



		public DeliveryPointController(IMapper mapper, IGenericService<DeliveryPoint> service )
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var all = await _service.GetAllAsync();
			var m_all = _mapper.Map<List<DeliveryPointDto>>(all.ToList());
            return CreateActionResult(CustomResponseDto<List<DeliveryPointDto>>.Success(m_all, 200));
		}

		[HttpPost]
		public async Task<IActionResult> Add(DeliveryPointDto DeliveryPointDto)
		{
			var DeliveryPoint = await _service.AddAsync(_mapper.Map<DeliveryPoint>(DeliveryPointDto));
			return CreateActionResult(CustomResponseDto<DeliveryPointDto>.Success(_mapper.Map<DeliveryPointDto>(DeliveryPoint),200));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddRange(List<DeliveryPointDto> DeliveryPointDtos)
		{
			var DeliveryPoints = await _service.AddRangeAsync(_mapper.Map<List<DeliveryPoint>>(DeliveryPointDtos));
            return CreateActionResult(CustomResponseDto<List<DeliveryPointDto>>.Success(_mapper.Map<List<DeliveryPointDto>>(DeliveryPoints), 200));
        }

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var DeliveryPoint = await _service.GetByIdAsync(id);
			return CreateActionResult(CustomResponseDto<DeliveryPointDto>.Success(_mapper.Map<DeliveryPointDto>(DeliveryPoint), 200));
		}

		[HttpPut]
		public async Task<IActionResult> Update(Guid id)
		{
			var entity = await _service.GetByIdAsync(id);
			await _service.Update(entity);
			return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
		}

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(entity);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }



    }
}

