using System;
using AutoMapper;
using App.Core.Services;
using App.Core.Models;
using App.Core.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
	public class VehicleController:BaseCustomController
	{
		private readonly IMapper _mapper;
		private readonly IGenericService<Vehicle> _service;



		public VehicleController(IMapper mapper, IGenericService<Vehicle> service )
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var all = await _service.GetAllAsync();
			var m_all = _mapper.Map<List<VehicleDto>>(all.ToList());
            return CreateActionResult(CustomResponseDto<List<VehicleDto>>.Success(200, m_all));
		}

		[HttpPost]
		public async Task<IActionResult> Add(VehicleDto vehicleDto)
		{
			var vehicle = await _service.AddAsync(_mapper.Map<Vehicle>(vehicleDto));
			return CreateActionResult(CustomResponseDto<VehicleDto>.Success(200, _mapper.Map<VehicleDto>(vehicle)));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddRange(List<VehicleDto> vehicleDtos)
		{
			var vehicles = await _service.AddRangeAsync(_mapper.Map<List<Vehicle>>(vehicleDtos));
            return CreateActionResult(CustomResponseDto<List<VehicleDto>>.Success(200, _mapper.Map<List<VehicleDto>>(vehicles)));
        }

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var vehicle = await _service.GetByIdAsync(id);
			return CreateActionResult(CustomResponseDto<VehicleDto>.Success(200, _mapper.Map<VehicleDto>(vehicle)));
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

