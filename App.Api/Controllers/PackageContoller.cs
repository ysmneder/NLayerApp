using System;
using AutoMapper;
using App.Core.Services;
using App.Core.Models;
using App.Core.Dtos;
using Microsoft.AspNetCore.Mvc;
using App.Api.Filter;

namespace App.API.Controllers
{
	public class PackageController:BaseCustomController
	{
		private readonly IMapper _mapper;
		private readonly IGenericService<Package> _service;



		public PackageController(IMapper mapper, IGenericService<Package> service )
		{
			_mapper = mapper;
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var all = await _service.GetAllAsync();
			var m_all = _mapper.Map<List<PackageDto>>(all.ToList());
            return CreateActionResult(CustomResponseDto<List<PackageDto>>.Success(200,m_all));
		}

		[HttpPost]
		public async Task<IActionResult> Add(PackageDto PackageDto)
		{
			var Package = await _service.AddAsync(_mapper.Map<Package>(PackageDto));
			return CreateActionResult(CustomResponseDto<PackageDto>.Success(200,_mapper.Map<PackageDto>(Package)));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> AddRange(List<PackageDto> PackageDtos)
		{
			var Packages = await _service.AddRangeAsync(_mapper.Map<List<Package>>(PackageDtos));
            return CreateActionResult(CustomResponseDto<List<PackageDto>>.Success(200,_mapper.Map<List<PackageDto>>(Packages)));
        }

        [ServiceFilter(typeof(NotFoundFilter<Package>))]
        [HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var Package = await _service.GetByIdAsync(id);
			return CreateActionResult(CustomResponseDto<PackageDto>.Success(200,_mapper.Map<PackageDto>(Package)));
		}

        [HttpPut]
		public async Task<IActionResult> Update(PackageDto packageDto)
		{
			await _service.Update(_mapper.Map<Package>(packageDto));
			return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
		}

        [ServiceFilter(typeof(NotFoundFilter<Package>))]
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            await _service.DeleteAsync(entity);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
        }



    }
}

