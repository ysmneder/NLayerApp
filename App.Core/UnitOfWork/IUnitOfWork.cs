using System;
namespace App.Core.UnitOfWork
{
	public interface IUnitOfWork
	{
		Task CommitAsync();
		void Commit();

	}
}

