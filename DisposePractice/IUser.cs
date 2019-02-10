using System;

namespace DisposePractice
{
	public interface IUser
	{
		Guid Id { get; set; }
		string Name { get; }
		string Surname { get; }

		void GetUserData();
		void PrintUserData();
	}
}